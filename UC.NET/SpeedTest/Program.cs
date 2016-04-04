using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcNetClient;
using AxlNetClient;
using System.Diagnostics;

namespace SpeedTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running");
            var sw = Stopwatch.StartNew();
            var axlClient = new AxlClient(new UcClientSettings { Server = "10.10.20.1", User = "administrator", Password = "ciscopsdt" });

            Console.WriteLine("Client created");
            Console.WriteLine(sw.Elapsed.ToString());

            var data = axlClient.Execute(client =>
            {
                Console.WriteLine("Executing");
                Console.WriteLine(sw.Elapsed.ToString());                
                var res = client.getPhone(new GetPhoneReq
                {
                    ItemElementName = ItemChoiceType140.name,
                    Item = "CSFuser001"
                });
                return res.@return;
            });
            if (data.Exception != null)
                throw data.Exception;

            Console.WriteLine(data.Value.phone.name);
            sw.Stop();
            Console.WriteLine(sw.Elapsed.ToString());
        }
    }
}
