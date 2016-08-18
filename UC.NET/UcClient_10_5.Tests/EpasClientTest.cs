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

            var failure = result.Value.Item as EpasNetClient.LoginStatusTypeFailure;
            if (failure != null)
                throw new Exception(failure.reason);

            Assert.IsNotNull(result.Value.Item);
        }

        [TestMethod]
        public void TestGetContacts()
        {
            var epasClient = new EpasClient("10.10.20.17");

            var result = epasClient.Execute(client =>
            {
                return client.login(new login
                {
                    username = "administrator",
                    ItemElementName = ItemChoiceType.password,
                    Item = "ciscopsdt",
                    clienttype = "thirdpartyapp",
                    force = true
                });
            });

            if (result.Exception != null)
                throw result.Exception;

            var loginkey = result.Value.Item as EpasNetClient.LoginStatusTypeSuccess;

            var result2 = epasClient.Execute(client =>
            {
                return client.login(new login
                {
                    username = "user01",
                    ItemElementName = ItemChoiceType.appsessionid,
                    Item = loginkey.sessionkey,
                    clienttype = "thirdclient"
                });
            });

            if (result2.Exception != null)
                throw result2.Exception;

            var userloginkey = result2.Value.Item as EpasNetClient.LoginStatusTypeSuccess;

            var contacts = epasClient.Execute(client =>
            {
                return client.getallconfig(new sessionkey { Value = userloginkey.sessionkey }, 
                    new getallconfig
                    {
                        contactinfo = new getallconfigContactinfo { },
                        nonpresenceawarecontacts = new getallconfigNonpresenceawarecontacts { }
                    });
            });

            //var delete = epasClient.Execute(client =>
            //{
            //    return client.deletecontact(new sessionkey { Value = userloginkey.sessionkey },
            //        new ContactListTypeGroup[] {
            //            new ContactListTypeGroup { name = "General", personaid = new ContactListTypeGroupPersonaid[] {
            //                new ContactListTypeGroupPersonaid { Value = "user01@abc.inc" } } } });
            //});

            if (contacts.Exception != null)
                throw contacts.Exception;
            
            Assert.IsTrue(contacts.Value.getcontactinforesp.Any());
        }
    }
}
