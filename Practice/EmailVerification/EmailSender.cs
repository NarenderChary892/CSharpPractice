using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Practice.EmailVerification
{
    class EmailSender
    {
        public void SendEmail()
        {
            using (StreamReader sr = new StreamReader(@"C:\Users\Operations01\source\repos\MyPractice\CSharpPractice\Practice\EmailVerification\email_template.html"))
            {


                string fileInfo = sr.ReadToEnd();
                //string to ="narendercharyuppala@gmail.com";
                string from = "narender.uppla@gmail.com";
                //string to = "narendercharyuppala@gmail.com";
                string to = "jayakanthanrs@gmail.com";
                // string to = "narendercharyuppala@gmail.com";
               


                string username = to.Split('@').ElementAtOrDefault(0);
                string domain = to.Split('@').ElementAtOrDefault(1);


                string body = fileInfo.Replace("#######", username);
                MailMessage message = new MailMessage(from, to)
                {
                    Subject = "Verification Email",
                    Body = body,
                    BodyEncoding = Encoding.UTF8,
                    IsBodyHtml = true
                };
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                System.Net.NetworkCredential basicCredential = new System.Net.NetworkCredential("narender.uppla@gmail.com", "");
                client.EnableSsl = true;
                // client.UseDefaultCredentials = true;
                client.Credentials = basicCredential;
                try
                {
                    client.Send(message);
                    Console.WriteLine("Email Sent successfully...!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }

            } 
 

        }
        public void SendEmail2()
        {
            MailMessage msg = new MailMessage();
            SmtpClient smtp = new SmtpClient();
            string emailId = "narendercharyuppala@gmail.com";
            msg.From = new MailAddress("narender.uppla@gmail.com");
            msg.To.Add(emailId);
            msg.Subject = "Confirmation email for account activation";
            //For testing replace the local host path with your lost host path and while making online replace with your website domain name
            //string ActivationUrl = "http://localhost:8665/FetchUserId(emailId) & "&EmailId=" & emailId);
            msg.Body = "Thanks for showing interest and registring in <a href='http://www.activationlink.com'> webservice.com<a> " +
                  " Please Thanks!";
            msg.IsBodyHtml = true;
            smtp.Credentials = new NetworkCredential("narender.uppla@gmail.com", "");
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";                
            smtp.EnableSsl = true;
            //NetworkCredential Credentials = new NetworkCredential("emailaddress@gmail.com", "Super2@17");
            //smtp.UseDefaultCredentials = false;

            try
            {
                smtp.Send(msg);
                Console.WriteLine("Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
