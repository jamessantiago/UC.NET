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
    }
}
