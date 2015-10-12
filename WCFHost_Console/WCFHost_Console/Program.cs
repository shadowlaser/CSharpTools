using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using WCFLibrary;

namespace WCFHost_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8082/User");
            using (ServiceHost host = new ServiceHost(typeof(User),baseAddress))
            {
                host.AddServiceEndpoint(typeof(IUser), new WSHttpBinding(), "");
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                host.Description.Behaviors.Add(smb);
                host.Open();
                Console.WriteLine("WCF中的http监听已启动。。。");
                Console.ReadLine();
                host.Close();
            }
        }
    }
}
