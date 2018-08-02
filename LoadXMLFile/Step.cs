using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LoadXMLFile
{
    public class Step
    {
        [XmlElement("Name")]
        public string Name { get; set; }
        [XmlElement("Desc")]
        public string Desc { get; set; }
    }
}
