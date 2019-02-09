using Homepage.Core.Helper;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace Homepage.Tests.Helper
{
    [TestFixture]
    public class EMailServiceTests
    { 
        private EMailService CreateService()
        {
            return new EMailService();
        }

        [Test]
        public async Task SendMessage_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateService();
            string from =  "Foo@bar.de";
            string subject = "TEST";
            string msgContent = "Inhalt";

            // Act
            var result = await unitUnderTest.SendMessage(
                from,
                subject,
                msgContent);

            // Assert
            Assert.That(result, Is.True);
        }
    }
}
