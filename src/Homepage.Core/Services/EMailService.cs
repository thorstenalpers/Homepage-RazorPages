using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace Homepage.Core.Helper
{
    /// <summary>
    /// Sendet EMails ueber den SendGrid
    /// </summary>
    public class EMailService
    {
        private readonly string _apikey = "todo";
        private readonly string _fromName = "Thorsten";
        private readonly string _fromEmail = "thorstenalpers@gmx.net";
        private readonly string _subject = "Anfrage über die Homepage";

        /// <summary>
        /// versendet eine EMail
        /// </summary>
        /// <param name="from">Adresse des Senders</param>
        /// <param name="subject">Betreff der EMail</param>
        /// <param name="msgContent">Inhalt der Nachricht</param>
        /// <returns>true, bei Erfolg, sonst false</returns>
        public async Task<bool> SendMessage(string from, string subject, string msgContent)
        {
            var client = new SendGridClient(_apikey);
            var msg = new SendGridMessage()
            {
                From = new EmailAddress(from, _subject),
                Subject = subject,
                PlainTextContent = msgContent
            };
            msg.AddTo(new EmailAddress(_fromEmail, _fromName));
            var response = await client.SendEmailAsync(msg);

            if (response.StatusCode == System.Net.HttpStatusCode.Accepted)
                return true;

            return false;
        }
    }
}
