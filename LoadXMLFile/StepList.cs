using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LoadXMLFile
{
    [XmlRoot("StepList")]
    public class StepList
    {
        [XmlElement("Step")]
        public List<Step> Steps { get; set; }
    }
}
