using System.Net.Mail;

namespace CleanCode._10_Comments
{
    public class MailService
    {
        public void SendEmailToCustomer(string email)
        {
            var client = new SmtpClient();
            var message = new MailMessage("noreply@site.com", email, "Your order was successfully placed.", ".");
            client.Send(message);
        }        
    }
}
