using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KeyServer
{
    internal class Program
    {
        public static string starttime;

        static void Main(string[] args)
        {
            starttime = DateTime.Now.ToString("dddd, d MMMM yyyy h:m.s tt");

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
