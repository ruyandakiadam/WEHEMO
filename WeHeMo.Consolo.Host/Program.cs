using System.Net;
using System.Net.Mail;

namespace WeHeMo.Consolo.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new SmtpClient();
            client.Host = "srvm07.trwww.com";
            client.Port = 587;
            client.EnableSsl = false;
            client.Credentials = new NetworkCredential("wehemo@exedra.com.tr", "W3hemomail"); //sunucuda username:password

            var message = new MailMessage();
            message.Body = "Sayın Yetkili,<br>adresine sahip sayfada sorun tespit edilmiştir.<br>" + "Alınan Hata: <span style:color:red></span><br>WEHEME Team";
            message.IsBodyHtml = true;
            message.Subject = "WEHEMO Notification";
            message.From = new MailAddress("wehemo@exedra.com.tr");
            message.To.Add("talipturkmentr@gmail.com.tr");
            client.Send(message);
        }
    }
}
