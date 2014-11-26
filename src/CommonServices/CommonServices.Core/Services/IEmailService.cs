namespace CommonServices.Core.Services
{
  public interface IEmailService
  {
    void Send(string tos, string subject, string body);
  }
}