using System;
using System.ServiceModel;

namespace WcfService.Host
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                using (ServiceHost host = new ServiceHost(typeof(WcfService.AppService)))
                {
                    host.Open();
                    Console.WriteLine("Host started at http://localhost:8080");
                    Console.Write("> ");
                    string end = Console.ReadLine();
                    while (end != "1")
                    {
                        Console.Write("> ");
                        end = Console.ReadLine();
                    }
                    host.Close();
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
            }
        }
    }
}