using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AxlNetClient;
using System.Linq;
using System.Threading.Tasks;
using RosterNetClient;
using UcNetClient;

namespace UcClient_10_5.Tests
{
    [TestClass]
    public class RosterClientTest
    {
        [TestMethod]
        public void GetRosterUserTest()
        {
            var rosterClient = new RosterClient(new UcClientSettings { Server = "10.10.20.17", User = "administrator", Password = "ciscopsdt" });

            var result = rosterClient.Execute(client =>
            {
                return client.executeSQLQuery(new RosterNetClient.ExecuteSQLQueryReq
                {
                    sql = @"SELECT TRIM(t.tabname) || '.' || TRIM(c.colname) AS table_dot_column
  FROM informix.systables  AS t
  JOIN informix.syscolumns AS c ON t.tabid = c.tabid
 WHERE t.tabtype = 'T'
   AND t.tabid >= 100
 ORDER BY t.tabname,
                    c.colno; "
                });
            });

            var res2 = rosterClient.Execute(client =>
            {
                return client.getClusterInfo(new GetClusterInfoReq
                {
                });
            });

            if (result.Exception != null)
                throw result.Exception;

            Assert.IsNotNull(result.Value);            
        }
    }
}
