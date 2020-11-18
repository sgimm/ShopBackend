using System.Net;
using System.Net.Mail;
using ValkyraECommerce.DatabaseDto.Shop;

namespace ValkyraECommerce.Helpers
{
    public class SendMailHelper
    {
        private SmtpClient smptClient;
        public SendMailHelper()
        {
            smptClient = new SmtpClient("smtp.ionos.de");
            smptClient.Port = 587;
            smptClient.EnableSsl = true;
            smptClient.UseDefaultCredentials = false;
            smptClient.Credentials = new NetworkCredential() { UserName = "info@valkyra.de", Password = "K@g@mi99" };
        }

        public void SendMail(CustomerWebAccount customerWebAccount, EmailValidation emailValidation)
        {
            MailMessage mailMessage = new MailMessage("info@valkyra.de", customerWebAccount.Email);
            mailMessage.Body = "blah blub: http://www.valkyra.de/api/CustomerRegister/validate/"+emailValidation.ValidationId;
            mailMessage.Subject = "Valkyra Shop Email validation Link";
            smptClient.Send(mailMessage);
        }
    }
}
