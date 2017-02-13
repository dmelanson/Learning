using Nancy.Hosting.Self;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NancyExampleConsole
{
    class Program
    {
        static void Main()
        {
            var url = "http://127.0.0.1:9000";

            using (var host = new NancyHost(new Uri(url)))  
            {
                host.Start();
                Console.WriteLine("Nancy Server listening on {0}", url);
                Console.ReadLine();
            }

        }
    }
}
