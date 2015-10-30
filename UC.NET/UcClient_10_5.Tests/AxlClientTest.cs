using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AxlNetClient;
using System.Linq;
using System.Threading.Tasks;

namespace UcClient_10_5.Tests
{
    [TestClass]
    public class AxlClientTest
    {
        [TestMethod]
        public async Task CreateUser()
        {
            var axlClient = new AxlClient(new AxlClientSettings { Server = "10.10.20.1", User = "administrator", Password = "ciscopsdt" });

            var addUserResult = await axlClient.ExecuteAsync(async client =>
            {
                var userId = Guid.NewGuid().ToString();
                var request = new AddUserReq
                {
                    user = new XUser
                    {
                        userid = userId,
                        userIdentity = userId,
                        password = "P@ssw0rd",
                        firstName = "test",
                        lastName = "test"
                    }
                };
                var response = await client.addUserAsync(request);
                return response.addUserResponse1.@return;
            });

            Assert.Inconclusive(addUserResult.Exception.Message);
            Assert.IsNull(addUserResult.Exception);

            var users = await axlClient.ExecuteAsync(async client =>
            {
                var request = new ListUserReq
                {
                    returnedTags = new LUser { firstName = string.Empty },
                    searchCriteria = new ListUserReqSearchCriteria { firstName = "%" }
                };
                var response = await client.listUserAsync(request);
                return response.listUserResponse1.@return.Select(u => u.firstName).ToList();
            });

            Assert.IsTrue(users.Value.Any());
        }

        [TestMethod]
        public void CreateUser2()
        {
            var axlClient = new AxlClient(new AxlClientSettings { Server = "10.10.20.1", User = "administrator", Password = "ciscopsdt" });

            var addUserResult = axlClient.Execute(async client =>
            {
                var userId = Guid.NewGuid().ToString();
                var request = new AddUserReq
                {
                    user = new XUser
                    {
                        userid = userId,
                        userIdentity = userId,
                        password = "P@ssw0rd",
                        firstName = "test",
                        lastName = "test"
                    }
                };
                var response = await client.addUserAsync(request);
                return response.addUserResponse1.@return;
            });

            Assert.IsNull(addUserResult.Exception);

            var users = axlClient.Execute(client =>
            {
                var request = new ListUserReq
                {
                    returnedTags = new LUser { firstName = string.Empty },
                    searchCriteria = new ListUserReqSearchCriteria { firstName = "%" }
                };
                var response = client.listUser(request);
                return response.@return.Select(u => u.firstName).ToList();
            });

            Assert.IsTrue(users.Value.Any());

        }

        //[TestMethod]
        //public void AddPhone()
        //{
        //    var axlClient = new AxlClient(new AxlClientSettings { Server = "10.10.20.1", User = "administrator", Password = "ciscopsdt" });

        //    var addPhone = axlClient.Execute(async client =>
        //    {
        //        var request = new AddPhoneReq
        //        {
        //            phone = new XPhone
        //            {
        //                phoneTemplateName = new XFkType { Value = "CSF_PhoneTemplate" },
        //                devicePoolName = new XFkType { Value = "Default" },
        //                locationName = new XFkType {  Value = "Hub_None" },


        //            }
        //        };
        //    });
        //}

        [TestMethod]
        public async Task QueryDatabase()
        {
            var axlClient = new AxlClient(new AxlClientSettings { Server = "10.10.20.1", User = "administrator", Password = "ciscopsdt" });

            var data = await axlClient.ExecuteAsync(async client =>
            {
                var res = await client.executeSQLQueryAsync(new ExecuteSQLQueryReq
                {
                    sql = "select * from device where name = 'CSFuser001'"
                });

                return res.executeSQLQueryResponse1.ToString();
            });
            if (data.Exception != null)
                throw data.Exception;
            else
                Assert.IsTrue(data.Value.Any());
        }

        [TestMethod]
        public void GetPhone()
        {
            var axlClient = new AxlClient(new AxlClientSettings { Server = "10.10.20.1", User = "administrator", Password = "ciscopsdt" });

            var data = axlClient.Execute(client =>
            {
                var res = client.getPhone(new GetPhoneReq
                {
                    ItemElementName = ItemChoiceType140.name,
                    Item = "CSFuser001"
                });
                return res.@return.phone;
            });

            Assert.IsNotNull(data);
        }
    }
}
