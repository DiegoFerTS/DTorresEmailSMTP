using System.Net;
using System.Net.Mail;

namespace BL
{
    public class Email
    {
        public bool SendEmail()
        {
            try
            {
                MailMessage mail = new MailMessage();

                mail.From = new MailAddress("DiegoFerTS12@gmail.com", "Diego Torres");
                mail.To.Add(new MailAddress("lescogido@digis01.com", "Leo Bravo"));
                mail.Subject = "Mensaje de prueba";
                //mail.IsBodyHtml = false;
                mail.Body = "Hola, este es un mensaje de prueba";

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    //smtp.Host = "smtp.gmail.com";
                    //smtp.Port = 587;                    
                    //smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    //System.Net.NetworkCredential networkCredential = new System.Net.NetworkCredential();
                    //networkCredential.UserName = "DiegoFerTs12@gmail.com";
                    //networkCredential.Password = "Welcome01$$$@";
                    //networkCredential.Password = "aayw ddtt urgu bkdj";
                    //smtp.UseDefaultCredentials = true;

                    smtp.Credentials = new NetworkCredential("diegoferts12@gmail.com", "aayw ddtt urgu bkdj");
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

    }
}