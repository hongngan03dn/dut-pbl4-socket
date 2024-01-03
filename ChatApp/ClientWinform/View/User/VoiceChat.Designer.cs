namespace ClientWinform.View.User
{
    partial class VoiceChat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStartRecord = new Guna.UI2.WinForms.Guna2Button();
            this.btnEndRecord = new Guna.UI2.WinForms.Guna2Button();
            this.timerVoiceLimit = new System.Windows.Forms.Timer(this.components);
            this.progressBarVoice = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnStartRecord
            // 
            this.btnStartRecord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStartRecord.BorderRadius = 8;
            this.btnStartRecord.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStartRecord.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStartRecord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStartRecord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStartRecord.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(251)))));
            this.btnStartRecord.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnStartRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(14)))));
            this.btnStartRecord.Location = new System.Drawing.Point(12, 41);
            this.btnStartRecord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStartRecord.Name = "btnStartRecord";
            this.btnStartRecord.Size = new System.Drawing.Size(104, 36);
            this.btnStartRecord.TabIndex = 8;
            this.btnStartRecord.Text = "Start";
            this.btnStartRecord.Click += new System.EventHandler(this.btnStartRecord_Click);
            // 
            // btnEndRecord
            // 
            this.btnEndRecord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEndRecord.BorderRadius = 8;
            this.btnEndRecord.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEndRecord.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEndRecord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEndRecord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEndRecord.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(251)))));
            this.btnEndRecord.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnEndRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(14)))));
            this.btnEndRecord.Location = new System.Drawing.Point(352, 41);
            this.btnEndRecord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEndRecord.Name = "btnEndRecord";
            this.btnEndRecord.Size = new System.Drawing.Size(104, 36);
            this.btnEndRecord.TabIndex = 9;
            this.btnEndRecord.Text = "End";
            this.btnEndRecord.Click += new System.EventHandler(this.btnEndRecord_Click);
            // 
            // timerVoiceLimit
            // 
            this.timerVoiceLimit.Interval = 1000;
            this.timerVoiceLimit.Tick += new System.EventHandler(this.timerVoiceLimit_Tick);
            // 
            // progressBarVoice
            // 
            this.progressBarVoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(214)))), ((int)(((byte)(200)))));
            this.progressBarVoice.Location = new System.Drawing.Point(12, 105);
            this.progressBarVoice.MarqueeAnimationSpeed = 1000;
            this.progressBarVoice.Maximum = 24;
            this.progressBarVoice.Name = "progressBarVoice";
            this.progressBarVoice.Size = new System.Drawing.Size(444, 10);
            this.progressBarVoice.Step = 1;
            this.progressBarVoice.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarVoice.TabIndex = 12;
            // 
            // VoiceChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(468, 162);
            this.Controls.Add(this.progressBarVoice);
            this.Controls.Add(this.btnEndRecord);
            this.Controls.Add(this.btnStartRecord);
            this.Name = "VoiceChat";
            this.ShowIcon = false;
            this.Text = "VoiceChat";
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnStartRecord;
        private Guna.UI2.WinForms.Guna2Button btnEndRecord;
        private System.Windows.Forms.Timer timerVoiceLimit;
        private System.Windows.Forms.ProgressBar progressBarVoice;
    }
}