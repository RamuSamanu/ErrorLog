using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace Sample
{
    public class SendMail
    {
        public static string Sentemail(string errorMessage)
        {
            try
            {
                MailMessage msg = new MailMessage();
                SmtpClient smt = new SmtpClient();
                msg.From = new MailAddress("ramu.ibt@gmail.com");
                msg.To.Add("ramu.ibt@gmail.com");
                msg.Subject = "Error Log";
                msg.Body = errorMessage;
                smt.Host = "smtp.gmail.com";
                System.Net.NetworkCredential ntwd = new NetworkCredential();
                ntwd.UserName = "ramu.ibt@gmail.com"; //Your Email ID  
                ntwd.Password = "xxxxxx"; // Your Password  
                smt.UseDefaultCredentials = true;
                smt.Credentials = ntwd;
                smt.Port = 587;
                smt.EnableSsl = true;
                smt.Send(msg);
                Console.Write("Email Sent Successfully");
            }
            catch (Exception ex)
            {

                throw;
            }
            return "Successful";
        }
    }
}
