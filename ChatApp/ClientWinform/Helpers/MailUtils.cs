using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClientWinform.Helpers
{
    public class MailUtils
    {
        private readonly static string _senderEmailAddress = "acccrush@gmail.com";
        private readonly static string _senderEmailPassword = "swkjjxmqekybmzkc";
        private readonly static string _smtpServerAddress = "Smtp.gmail.com";
        private readonly static int _smtpServerPort = 587;

        public static bool SendMail(string _from, string _to, string _subject, string _body, SmtpClient client)
        {
            // Tạo nội dung Email
            MailMessage message = new MailMessage(
                from: _from,
                to: _to,
                subject: _subject,
                body: _body
            );
            message.BodyEncoding = System.Text.Encoding.UTF8;
            message.SubjectEncoding = System.Text.Encoding.UTF8;
            message.IsBodyHtml = true;
            message.ReplyToList.Add(new MailAddress(_from));
            message.Sender = new MailAddress(_from);


            try
            {
                client.SendMailAsync(message);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public static string SendResetPassword(string email)
        {
            string password = randomPassword();
            using (var smtpClient = new SmtpClient(_smtpServerAddress, _smtpServerPort))
            {
                smtpClient.EnableSsl = true;
                //smtpClient.Timeout = 10000;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(_senderEmailAddress, _senderEmailPassword);

                var message = new MailMessage(_senderEmailAddress, email);

                message.Subject = "Reset Password";
                message.Body = $"Your new password is {password}";

                smtpClient.Send(message);
            };
            return password;
        }
        public static string randomPassword()
        {
            int length = 12;

            const string allowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_-+=[]{};:,.<>?";
            byte[] randomBytes = new byte[length];
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(randomBytes);
            }
            StringBuilder password = new StringBuilder(length);
            foreach (byte b in randomBytes)
            {
                password.Append(allowedChars[b % allowedChars.Length]);
            }

            return password.ToString();
        }
    }
}
