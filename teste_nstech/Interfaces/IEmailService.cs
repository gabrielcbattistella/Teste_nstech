using teste_nstech.Models;

namespace teste_nstech.Interfaces
{
    public interface IEmailService
    {
        Task Send(EmailMessageModel emailMessage);
    }
}
