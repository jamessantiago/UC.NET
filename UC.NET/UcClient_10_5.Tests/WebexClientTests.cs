using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Threading.Tasks;
using UcNetClient;
using WebexNetClient;

namespace UcClient_10_5.Tests
{
    [TestClass]
    public class WebexClientTest
    {
        [TestMethod]
        public void GetUserTest()
        {
            var webexClient = new WebexClient(new WebexClientSettings()
            {
                SiteId = 690319,
                PartnetId = "g0webx",
                Server = "apidemoeu.webex.com",
                User = "TestConf12",
                Password = "password",
                Email = "test.user@email.domain"

            });
            var user = webexClient.Execute(client =>
            {
                var res = client.getUser(new getUser
                {
                    webExId = "TestConf12"
                });

                return res;
            });

            if (user.Exception != null) throw user.Exception;

            Assert.IsNotNull(user);
        }       
    }
}