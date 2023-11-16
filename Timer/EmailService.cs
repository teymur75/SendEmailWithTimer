using System.Net;
using System.Net.Mail;

namespace Timer
{
	public class EmailService : BackgroundService
	{

		protected override async Task ExecuteAsync(CancellationToken stoppingToken)
		{
			while (!stoppingToken.IsCancellationRequested)
			{
				// Her iki dakikada bir e-posta gönderme metodu çağrılır
				SendEmail();

				// 2 dakika bekle
				await Task.Delay(TimeSpan.FromSeconds(30), stoppingToken);
			}
		}

		private void SendEmail()
		{
			try
			{
				// E-posta gönderici bilgilerini ayarlayın
				string fromAddress = "Teymurrahemlee075@gmail.com";
				string toAddress = "teymur.rahimli@code.edu.az";
				string subject = "Konu: Bildirim";
				string body = "E-posta içeriği: Bu bir test mesajıdır.";

				// SmtpClient oluşturun ve gerekli ayarları yapın
				SmtpClient smtp = new SmtpClient();
				smtp.Port = 587;
				smtp.Host = "smtp.gmail.com";
				smtp.EnableSsl = true;
				smtp.Credentials = new NetworkCredential($"Teymurrahemlee075@gmail.com", "rbtfbblhdbacoftq");

				// E-posta oluşturun ve gönderin
				MailMessage mailMessage = new MailMessage(fromAddress, toAddress, subject, body);
				smtp.Send(mailMessage);

				Console.WriteLine("E-posta gönderildi.");
			}
			catch (Exception ex)
			{
				Console.WriteLine("Hata oluştu: " + ex.Message);
			}
		}
	}
}
