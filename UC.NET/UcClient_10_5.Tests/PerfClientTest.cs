using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerfNetClient;
using System.Linq;
using System.Threading.Tasks;
using UcNetClient;

namespace UcClient_10_5.Tests
{
    [TestClass]
    public class PerfClientTest
    {
        private PerfClient perfClient = new PerfClient(new UcClientSettings { Server = "10.10.20.1", User = "administrator", Password = "ciscopsdt" });

        [TestMethod]
        public void ListCountersTest()
        {
            var counters = perfClient.Execute(client =>
            {
                return client.perfmonListCounter("10.10.20.17");
            });

            if (counters.Exception != null) throw counters.Exception;
            Assert.IsTrue(counters.Value.Count() > 0);
        }

        [TestMethod]
        public void GetCounterDataTest()
        {
            var data = perfClient.Execute(client =>
            {
                return client.perfmonCollectCounterData("10.10.20.17", new ObjectNameType
                {
                    Value = "Cisco XCP TC"
                });
            });

            if (data.Exception != null) throw data.Exception;
            Assert.IsNotNull(data.Value);
        }
    }
}
