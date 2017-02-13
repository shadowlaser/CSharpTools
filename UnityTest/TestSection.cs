using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace UnityTest
{
    class TestSection
    {
        public string name { get; set; }
    }
   

    class TestSectionHandler: System.Configuration.IConfigurationSectionHandler
    {
        public object Create(object parent, object configContext, XmlNode section)
        {
            string siteName = section.SelectSingleNode("qq").InnerText;
            
            return new TestSection() { name = siteName };
        }
    }
}
