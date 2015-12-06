using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcNetClient;
using AxlNetClient;

namespace SpeedTest
{
    class Program
    {
        static void Main(string[] args)
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

            Console.WriteLine(data.Value.name);
            Console.ReadLine();
        }
    }
}
