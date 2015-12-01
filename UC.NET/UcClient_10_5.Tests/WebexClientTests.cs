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

        private static WebexClient webexClient = new WebexClient(new WebexClientSettings()
        {
            SiteId = 690319,
            PartnetId = "g0webx",
            Server = "apidemoeu.webex.com",
            User = "TestConf12",
            Password = "password",
            Email = "test.user@email.domain"

        });

        [TestMethod]
        public async Task GetUserTest()
        {
            
            var user = await webexClient.ExecuteAsync(client =>
            {
                var res = client.getUserAsync(new getUser
                {
                    webExId = "TestConf12"
                });

                return res;
            });

            if (user.Exception != null) throw user.Exception;

            Assert.IsNotNull(user.Value);
        }

        [TestMethod]
        public void SetUserTest()
        {
            var user = webexClient.Execute(client =>
            {
                var res = client.setUser(new setUser
                {
                    webExId = "TestConf12",
                    active = activeType.ACTIVATED
                });
                return res;
            });

            if (user.Exception != null) throw user.Exception;

            Assert.IsNotNull(user.Value);
        }
    }
}