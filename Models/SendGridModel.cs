using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using static NapelliFrameWork.StatusInfo;

namespace NapelliWebAPI.Models
{
    public class SendGridModel
    {
        public string error { get; set; }
        public int errorcode { get; set; }

        public async Task SendEmail(string FromEmailID, string ToEmailIds, string subject, string htmlContent)
        {
            // string subject1 = subject;
            UserInfo uinfo = new UserInfo();

            string htmlContent1 = HttpUtility.UrlDecode(htmlContent);
            //Application app = new Application(uinfo);

            //objsndmail.htmlContent = HttpUtility.UrlDecode(objsndmail.htmlContent);
            //DataTable dtprofile = app.GetAllProfileOption();
            //DataRow[] results = dtprofile.Select("profile_name = 'emailapikey' AND status = 'A'");
            //string apiKey = null;
            //foreach (DataRow row in results)
            //{
            //    apiKey = row["profile_desc"].ToString();
            //}
            var apiKey = "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";
            // var apiKey = _configuration.GetSection("SENDGRID_API_KEY").Value;
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress(FromEmailID, "prasanna.a@vcrbizz.com");
            List<EmailAddress> tos = new List<EmailAddress> { };
            string[] toEmails = ToEmailIds.Split(new Char[] { ',', ';' });
            for (int i = 0; i < toEmails.Length; i++)
            {
                tos.Add(new EmailAddress(toEmails[i]));
            };
            var displayRecipients = true; // set this to true if you want recipients to see each others mail id
            var msg = MailHelper.CreateSingleEmailToMultipleRecipients(from, tos, subject, "", htmlContent1, displayRecipients);

            var response = await client.SendEmailAsync(msg);
        }
    }
}
