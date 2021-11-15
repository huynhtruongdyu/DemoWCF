using System;

namespace WcfService.Client
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            AppService.AppServiceClient client = new AppService.AppServiceClient("BasicHttpBinding_IAppService");
            var greeting = client.Greeting("Duy Huynh");
            Console.WriteLine(greeting);
            Console.ReadKey();
        }
    }
}