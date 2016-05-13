using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EpasNetClient;
using System.Linq;
using System.Threading.Tasks;
using UcNetClient;

namespace UcClient_10_5.Tests
{
    [TestClass]
    public class EpasClientTest
    {

        [TestMethod]
        public void TestConnect()
        {
            var epasClient = new EpasClient("10.10.20.17");

            var result = epasClient.Execute(client =>
            {
                return client.login(new login
                {
                    username = "administrator",
                    ItemElementName = ItemChoiceType.password,
                    Item = "ciscopsdt",
                    clienttype = "thirdpartyapp"
                });
            });

            if (result.Exception != null)
                throw result.Exception;

            Assert.IsNotNull(result.Value.Item);
        }
    }
}
