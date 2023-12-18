using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MyNuget
{
    public class MailHelper
    {
        public void SendMail(string subject, string body,string cc,string to,string from,bool isHtml)
        {
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com",587);
            smtpClient.Credentials = new NetworkCredential(from, "ahqq wteq bdyq jgst");
            smtpClient.EnableSsl = true;

            MailMessage message = new MailMessage()
            {
                From=new MailAddress(from),
                Subject=subject,
                Body=body
            };
            message.To.Add(new MailAddress(to));
            message.CC.Add(new MailAddress(cc));
            message.IsBodyHtml = isHtml;
            try
            {
                smtpClient.Send(message);

            }
            catch (Exception exd)
            {

                Console.WriteLine(exd.Message);
            }
        }
    }

}
