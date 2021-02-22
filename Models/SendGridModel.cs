using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using static NapelliFrameWork.StatusInfo;
using static System.Net.Mime.MediaTypeNames;

namespace NapelliWebAPI.Models
{
    public class SendGridModel
    {
        public string error { get; set; }
        public int errorcode { get; set; }

        //public async Task<string> SendEmail(String ToEmailIds)
        //{
        //    string htmlContent = null;
        //    UserDetailsModel umodel = new UserDetailsModel();
        //    SendGridModel email = new SendGridModel();
        //    DataTable dt = umodel.CheckMail(ToEmailIds, "");
        //    foreach (DataRow row in dt.Rows)
        //    {
        //        ToEmailIds = row["email_id"].ToString();
        //        htmlContent = row["password"].ToString();
        //    }
        //    var response = await email.Execute(ToEmailIds, htmlContent);
        //    var status = response.ToString();
        //    if (status == "Accepted")
        //    {
        //        return  "Mail sent successfully";
        //    }
        //    else
        //    {
        //        return "Not sent";
        //    }
        //}

        public async Task Execute(string ToEmailIds, string htmlContent)
        {
            //var apiKey = Environment.GetEnvironmentVariable("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");
            var apiKey = "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";
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("prasanna.a@vcrbizz.com", "VCR");
            var subject = "Forgot Password";
            var to = new EmailAddress(ToEmailIds, "Prasanna");
            var htmlContent1 = "Password:" + "" + htmlContent;
            var msg = MailHelper.CreateSingleEmail(from, to, subject, "", htmlContent1);
            var response = await client.SendEmailAsync(msg);
            var status = response.StatusCode.ToString();
            //return response.StatusCode;
        }

    }
}
