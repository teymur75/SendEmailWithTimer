namespace Timer
{
	public class EmailServiceLauncher : IHostedService
	{
		private readonly EmailService _emailService;

		public EmailServiceLauncher(EmailService emailService)
		{
			_emailService = emailService ?? throw new ArgumentNullException(nameof(emailService));
		}

		public Task StartAsync(CancellationToken cancellationToken)
		{
			_emailService.StartAsync(cancellationToken);
			return Task.CompletedTask;
		}

		public Task StopAsync(CancellationToken cancellationToken)
		{
			_emailService.StopAsync(cancellationToken);
			return Task.CompletedTask;
		}
	}
}
