using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using NAudio.Wave;
using System.IO;
using ClientWinform.DTO;

namespace ClientWinform.View.User
{
    public partial class VoiceChat : Form
    {
        public DTO.User userFrom = new DTO.User();
        public DTO.User userTo = new DTO.User();
        public VoiceChat()
        {
            InitializeComponent();
        }

        public VoiceChat(DTO.User userFrom, DTO.User userTo) : this()
        {
            this.userFrom = userFrom;
            this.userTo = userTo;
        }

        [DllImport("winmm.dll")]
        private static extern int mciSendString(string MciComando, string MciRetrno, int MciRectrnoLeng, int CallBack);
        string currentFile = "";
        static string pathFileStorage = "..\\..\\FileStorage\\";

        private void btnStartRecord_Click(object sender, EventArgs e)
        {
            timerVoiceLimit.Start();
            mciSendString("open new type waveaudio alias Som", null, 0, 0);
            mciSendString("record Som", null, 0, 0);
            currentFile = "";
        }

        private void btnEndRecord_Click(object sender, EventArgs e)
        {
            timerVoiceLimit.Stop();
            mciSendString("pause Som", null, 0, 0);
            //SaveFileDialog saveFileDialog = new SaveFileDialog();
            //saveFileDialog.Filter = "wave|*.wav";
            //if (saveFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    mciSendString("save Som " + saveFileDialog.FileName, null, 0, 0);
            //    mciSendString("close Som", null, 0, 0);
            //}
            string tickNow = DateTime.Now.Ticks.ToString();
            string fname = userFrom.Id + "_" + userTo.Id + "_" + tickNow + "_VoiceSpeech.wav";
            string fnameLower = userFrom.Id + "_" + userTo.Id + "_" + tickNow + "_LowerVoiceSpeech.wav";
            string fullPath = pathFileStorage + fname;
            string fullPathLower = pathFileStorage + fnameLower;
            mciSendString("save Som " + fullPath, null, 0, 0);
            mciSendString("close Som", null, 0, 0);
            ConvertWavToLowQuality(fullPath, fullPathLower, 2000, 8);
            currentFile = fullPathLower;

            // check 85KB  == 25s
            long fileSize = new FileInfo(currentFile).Length;
            if (fileSize >= (1024 * 85))
            {
                MessageBox.Show("Failed. Record Speech only under 25 seconds. Record again.");
                return;
            }

            sendFileAudio();
            this.Close();
        }

        public static void ConvertWavToLowQuality(string inputFile, string outputFile, int sampleRate, int bitDepth)
        {
            using (var reader = new WaveFileReader(inputFile))
            {
                var newFormat = new WaveFormat(sampleRate, bitDepth, 1); // lower sample rate, bit depth, and mono channel 2000, 16, 1

                using (var conversionStream = new WaveFormatConversionStream(newFormat, reader))
                {
                    WaveFileWriter.CreateWaveFile(outputFile, conversionStream);
                }
            }
        }

        public void sendFileAudio()
        {
            if (BLL.UserBLL.checkIsHaveConnection(userFrom.Id, userTo.Id).Status == Constants.ConnectionsDescr.NOTCONNECT)
            {
                MessageBox.Show("Your connection had been deleted. You cannot chat with \"" + userTo.Username + "\"");
            }
            else
            {
                if (!String.IsNullOrWhiteSpace(currentFile))
                {
                    DTO.Message newMessage = new DTO.Message();
                    newMessage.IdFrom = userFrom.Id;
                    newMessage.ContentMsg = Path.GetFileName(currentFile);
                    newMessage.CreatedDate = DateTime.Now;
                    //loadedMessageCount++;
                    List<DTO.Message> msg = new List<DTO.Message>() { newMessage };
                    //await AddMessagesToChatPanel(msg, userFrom.Id, flowLayoutPanelChat);
                    //messageTxt.Focus();
                    try
                    {
                        SocketHandles.MailClient.sendFile(userFrom.Id, userTo.Id, currentFile, newMessage.CreatedDate);
                        currentFile = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
            }
        }

        private void timerVoiceLimit_Tick(object sender, EventArgs e)
        {
            progressBarVoice.PerformStep();
            if (progressBarVoice.Value == 24)
            {
                btnEndRecord_Click(sender, e);
            }
        }
    }
}
