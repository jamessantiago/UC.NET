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
            PartnetId = "g0webx!",
            Server = "apidemoeu.webex.com",
            User = "TestConfId3",
            Password = "password",
            Email = "test.user4@email.com"

        });

        [TestMethod]
        public async Task GetUserTest()
        {
            
            var user = await webexClient.ExecuteAsync(client =>
            {
                var res = client.getUserAsync(new getUser
                {
                    webExId = "TestConfId3"
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

        [TestMethod]
        public void CreateMeetingTest()
        {
            var meetings = webexClient.Execute(client =>
            {
                var res = client.createMeeting(new createMeeting
                {
                    accessControl = new accessControlType1
                    {
                        meetingPassword = "password"
                    },
                    metaData = new metaDataType1
                    {
                        confName = "Sample Meeting",
                        meetingType = 1,
                        agenda = "Test"
                    },
                    enableOptions = new enableOptionsType1
                    {
                        chat = true,
                        poll = true,
                        audioVideo = true
                    },
                    schedule = new scheduleType1
                    {
                        startDate = DateTime.Now.ToString(),
                        openTime = 900,
                        joinTeleconfBeforeHost = true,
                        duration = 20,
                        timeZoneID = 4
                    }
                });
                return res;
            });
            if (meetings.Exception != null) throw meetings.Exception;

            Assert.IsNotNull(meetings.Value);
        }

        [TestMethod]
        public void LstMeetingsTest()
        {
            var meetings = webexClient.Execute(client =>
            {
                var res = client.LstsummaryMeeting(new LstsummaryMeeting
                {
                    listControl = new lstControlType
                    {
                        startFrom = "1",
                        maximumNum = "10",
                        listMethod = lstMethodType.OR,
                        listMethodSpecified = true
                    },
                    order = new orderType3
                    {
                        orderBy = new orderByType3[] { orderByType3.CONFNAME, orderByType3.STARTTIME }
                    }
                });
                return res;
            });

            if (meetings.Exception != null) throw meetings.Exception;

            Assert.IsNotNull(meetings.Value);
        }

        [TestMethod]
        public void GetMeetingTest()
        {
            var meeting = webexClient.Execute(client =>
            {
                return client.GetMeeting(new GetMeeting
                {
                    meetingKey = 123456
                });
            });

            if (meeting.Exception != null) throw meeting.Exception;
        }

        [TestMethod]
        public void DeleteMeetingTest()
        {
            var results = webexClient.Execute(client =>
            {
                var res = client.DelMeeting(new DelMeeting
                {
                    meetingKey = 123456
                });
                return res;
            });

            if (results.Exception != null) throw results.Exception;

            Assert.IsNotNull(results.Value);
        }

    }
}