using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KeyServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] prefixes = { "http://localhost:8080/" };
            var server = new HttpServer(prefixes);
            server.Start();

            Console.WriteLine("Press enter to stop KeyServer...");
            Console.ReadKey();
            server.Stop();
            Environment.Exit(0);
        }
    }
}
