using CommonServices.Core.Services;
using System.Net;
using System.Net.Mail;

namespace CommonServices.Infrastructure.Services
{
  public class SmtpEmailService : IEmailService
  {
    private readonly string _host;
    private readonly int _port;
    private readonly string _userName;
    private readonly string _password;

    public SmtpEmailService(string host, int port, string userName, string password)
    {
      _host = host;
      _port = port;
      _userName = userName;
      _password = password;
    }

    public void Send(string tos, string subject, string body)
    {
      var client = new SmtpClient(_host, _port)
      {
        Credentials = new NetworkCredential(_userName, _password),
        EnableSsl = true,
      };

      var message = new MailMessage(_userName, tos, subject, body) { IsBodyHtml = true };
      client.Send(message);
    }
  }
}