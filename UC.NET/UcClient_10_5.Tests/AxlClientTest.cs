﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using AxlNetClient;
using System.Linq;
using System.Threading.Tasks;
using UcNetClient;

namespace UcClient_10_5.Tests
{
    [TestClass]
    public class AxlClientTest
    {
        [TestMethod]
        public async Task CreateUser()
        {
            var axlClient = new AxlClient(new UcClientSettings { Server = "10.10.20.1", User = "administrator", Password = "ciscopsdt" });

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
            var axlClient = new AxlClient(new UcClientSettings { Server = "10.10.20.1", User = "administrator", Password = "ciscopsdt" });

            var appresult = axlClient.Execute(client =>
            {
                var res = client.getAppUser(new GetAppUserReq
                {
                    ItemElementName = ItemChoiceType102.userid,
                    Item = "administrator"
                });
                return res.@return;
            });

            Assert.IsNull(appresult.Exception);

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
        //    var axlClient = new AxlClient(new UcClientSettings { Server = "10.10.20.1", User = "administrator", Password = "ciscopsdt" });

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
            var axlClient = new AxlClient(new UcClientSettings { Server = "10.10.20.1", User = "administrator", Password = "ciscopsdt" });

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
            var axlClient = new AxlClient(new UcClientSettings { Server = "10.10.20.1", User = "administrator", Password = "ciscopsdt" });

            var data = axlClient.Execute(client =>
            {
                var res = client.getPhone(new GetPhoneReq
                {
                    ItemElementName = ItemChoiceType140.name,
                    Item = "CSFuser001"
                });
                return res.@return.phone;
            });

            if (data.Exception != null) throw data.Exception;

            Assert.IsNotNull(data.Value);
        }

        [TestMethod]
        public void GetPhone10()
        {
            var axlClient = new AxlClient(new UcClientSettings { Server = "10.10.20.1", User = "administrator", Password = "ciscopsdt" });

            for (int i = 0; i < 25; i++)
            {
                var sw = new Stopwatch();
                sw.Start();
                var data = axlClient.Execute(client =>
                {
                    var res = client.getPhone(new GetPhoneReq
                    {
                        ItemElementName = ItemChoiceType140.name,
                        Item = "CSFuser001"
                    });                                        
                    return res.@return.phone;
                });

                if (data.Exception != null) throw data.Exception;
                sw.Stop();                
                if (sw.ElapsedMilliseconds > 10000) throw new Exception("Took too long: " + sw.ElapsedMilliseconds);
            }
        }

        [TestMethod]
        public void EnableUser()
        {
            var axlClient = new AxlClient(new UcClientSettings { Server = "10.10.20.1", User = "administrator", Password = "ciscopsdt" });

            var data = axlClient.Execute(client =>
            {
                var res = client.updateUser(new UpdateUserReq
                {
                    ItemElementName = ItemChoiceType6.userid,
                    Item = "user01",
                    homeCluster = "true"
                });
                return res.@return;
            });

            Assert.IsTrue(data.Exception == null | data.Exception.Message == "");

            var data2 = axlClient.Execute(client =>
            {
                var res = client.updateUser(new UpdateUserReq
                {
                    ItemElementName = ItemChoiceType6.userid,
                    Item = "user01",
                    imAndPresenceEnable = "true"
                });
                return res.@return;
            });

            Assert.IsTrue(data2.Exception == null | data2.Exception.Message == "");
        }

        [TestMethod]
        public void DisableUser()
        {
            var axlClient = new AxlClient(new UcClientSettings { Server = "10.10.20.1", User = "administrator", Password = "ciscopsdt" });

            var data = axlClient.Execute(client =>
            {
                var res = client.updateUser(new UpdateUserReq
                {
                    ItemElementName = ItemChoiceType6.userid,
                    Item = "user01",
                    homeCluster = "false",
                    imAndPresenceEnable = "false",
                    calendarPresence = "false"
                });
                return res.@return;
            });

            Assert.IsNull(data.Exception);
        }

        [TestMethod]
        public void ListServers()
        {
            var axlClient = new AxlClient(new UcClientSettings { Server = "10.10.20.1", User = "administrator", Password = "ciscopsdt" });
            var presenceservers = axlClient.Execute(client =>
            {
                return client.listAssignedPresenceServers(new ListAssignedPresenceServersReq
                {
                    searchCriteria = new ListAssignedPresenceServersReqSearchCriteria
                    {
                        name = ""
                    }
                });
            });

            var servers = axlClient.Execute(client =>
            {
                return client.listProcessNode(new ListProcessNodeReq {
                    searchCriteria = new ListProcessNodeReqSearchCriteria { name = "" },
                    returnedTags = new LProcessNode()
                });
            });

            if (servers.Exception != null) throw servers.Exception;
            Assert.IsNotNull(servers.Value);
        }
    }
}
