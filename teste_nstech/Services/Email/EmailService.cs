using FluentEmail.Core;
using teste_nstech.Interfaces;
using teste_nstech.Models;

namespace teste_nstech.Services.Email
{
    public class EmailService : IEmailService
    {
        private readonly ILogger<EmailService> _logger;
        private readonly IFluentEmailFactory _fluentEmailFactory;

        public EmailService(ILogger<EmailService> logger, IFluentEmailFactory fluentEmailFactory)
        {
            _logger = logger;
            _fluentEmailFactory = fluentEmailFactory;
        }

        public async Task Send(EmailMessageModel emailMessageModel)
        {
            await _fluentEmailFactory.Create().To(emailMessageModel.ToAddress)
                .Subject(emailMessageModel.Subject)
                .Body(emailMessageModel.Body, true)
                .SendAsync();
        }
    }
}
