using CommonServices.Core.Services;
using CommonServices.Infrastructure.Services;
using NUnit.Framework;

namespace CommonServices.Infrastructure.Tests.Services
{
  [TestFixture]
  public class SmtpEmailService_Tests
  {
    private IEmailService _service;

    [SetUp]
    public void Given_A_Smtp_SmtpEmailService()
    {
      const string userName = "[ADD USERNAME HERE]";
      const string password = "[ADD PASSWORD HERE]";
      _service = new SmtpEmailService("smtp.gmail.com", 587, userName, password);
    }

    [Test]
    public void It_Should_Be_Able_To_Send_An_Email()
    {
      const string tos = "[ADD TOS HERE]";
      _service.Send(tos, "The subject", "<h1>The body</h1>");
    }
  }
}