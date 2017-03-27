using System;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.Identity;
using T7.ControleFinanceiro.Core.Configuration;

namespace T7.ControleFinanceiro.Infra.CrossCutting.Identity.Configuration
{
    public class EmailService : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {

            //var text = HttpUtility.HtmlEncode(message.Body);
            //var msg = new MailMessage
            //{
            //    From = new MailAddress(AppConfig.Get().IdentityEmail.UserName, AppConfig.Get().IdentityEmail.Label)
            //};

            //msg.To.Add(new MailAddress(message.Destination));
            //msg.Subject = message.Subject;
            //msg.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(text, null, MediaTypeNames.Text.Plain));
            //msg.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(text, null, MediaTypeNames.Text.Html));

            //var smtpClient = new SmtpClient(AppConfig.Get().IdentityEmail.Smtp, AppConfig.Get().IdentityEmail.Port);
            //var credentials = new NetworkCredential(AppConfig.Get().IdentityEmail.UserName, AppConfig.Get().IdentityEmail.Password);
            //smtpClient.Credentials = credentials;
            //smtpClient.EnableSsl = true;
            //smtpClient.Send(msg);

            if (AppConfig.Get().Server == "Prod")
            {
                var client = new SmtpClient
                {
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(AppConfig.Get().IdentityEmail.UserName, AppConfig.Get().IdentityEmail.Password),
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Host = AppConfig.Get().IdentityEmail.Smtp,
                    Port = AppConfig.Get().IdentityEmail.Port
                };

                MailAddress de = new MailAddress(AppConfig.Get().IdentityEmail.UserName, AppConfig.Get().IdentityEmail.Label);
                MailAddress para = new MailAddress(message.Destination);

                using (MailMessage mail = new MailMessage(de, para))
                {
                    mail.Subject = message.Subject;
                    mail.IsBodyHtml = true;
                    mail.Body = message.Body;

                    client.Send(mail);
                };
            }

            return Task.FromResult(0);
        }
    }
}