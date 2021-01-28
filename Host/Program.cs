using System;
using System.ServiceModel;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(WCF_Service_task.Service)))
            {
                host.Open();
                Console.WriteLine("Host started");
                Console.ReadLine();
                host.Close();
            }
        }
    }
}
