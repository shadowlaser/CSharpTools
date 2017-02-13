using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using Newtonsoft.Json;
using System;
using System.Configuration;

namespace UnityTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //IUnityContainer container = new UnityContainer();
            ////container.RegisterType<IKiss, Boy>();
            ////IKiss boy = container.Resolve<IKiss>();
            ////Lily lily = new Lily(boy);
            ////lily.kiss();
            //UnityConfigurationSection configuration = ConfigurationManager.GetSection(UnityConfigurationSection.SectionName) as UnityConfigurationSection;
            //configuration.Configure(container, "defaultContainer");
            //var instances = container.Resolve<IKiss>();
            //Lily lily = new Lily(instances);
            //lily.kiss();

            //web.config自定义节测试
            TestSection ts = ConfigurationManager.GetSection("testsection") as TestSection;
            Console.WriteLine(ts.name);


            string output = JsonConvert.SerializeObject(ts,Formatting.Indented);

            Console.WriteLine(output);
            Console.ReadKey();
        }
    }

    public interface IKiss
    {
        void kiss();
    }

    public class Lily : IKiss
    {
        public IKiss boy;

        public Lily(IKiss obj)
        {
            boy = obj;
        }

        public void kiss()
        {
            boy.kiss();
            Console.WriteLine("lily kissing");
        }
    }

    public class Boy : IKiss
    {
        public void kiss()
        {
            Console.WriteLine("boy kissing");
        }
    }
}