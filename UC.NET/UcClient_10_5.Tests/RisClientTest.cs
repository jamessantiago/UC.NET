using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AxlNetClient;
using System.Linq;
using System.Threading.Tasks;
using RisNetClient;
using UcNetClient;

namespace UcClient_10_5.Tests
{
    [TestClass]
    public class RisClientTest
    {
        [TestMethod]
        public void SelecCmDevice()
        {
            var risClient = new RisClient(new UcClientSettings { Server = "10.10.20.1", User = "administrator", Password = "ciscopsdt" });

            var result = risClient.Execute(client =>
            {
                var criteria = new CmSelectionCriteria()
                {
                    MaxReturnedDevices = 1000,
                    DeviceClass = "Any",
                    Model = 255, //refers to any device, full listing here: https://developer.cisco.com/site/sxml/documents/api-reference/risport/#ModelTable
                    Status = "Any",
                    NodeName = string.Empty, //null for all nodes
                    SelectBy = CmSelectBy.Name,
                    SelectItems = new ArrayOfSelectItem() { new SelectItem() { Item = "SIPTrunktoCUP" } },
                    //SelectItems = new ArrayOfSelectItem(),  //blank for everything
                    Protocol = ProtocolType.Any,
                    DownloadStatus = DeviceDownloadStatus.Any,
                };

                var res = client.selectCmDevice(string.Empty, criteria);                
                return res;
            });

            if (result.Exception != null)
                throw result.Exception;

            Assert.IsTrue(result.Value.SelectCmDeviceResult.TotalDevicesFound == 1);
        }
    }
}
