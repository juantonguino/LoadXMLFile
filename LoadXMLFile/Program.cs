using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LoadXMLFile
{
    class Program
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static string FilePath;

        static void Main(string[] args)
        {
            FilePath=Properties.Configuration.Default.XMLPath;
            StepList MyObj = DeserializeXMLFileToObject<StepList>(FilePath);
        }

        public static T DeserializeXMLFileToObject<T>(string XmlFilename)
        {
            T returnObject = default(T);
            try
            {
                StreamReader xmlStream = new StreamReader(XmlFilename);
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                returnObject = (T)serializer.Deserialize(xmlStream);
                Log.Info("Correcto");
            }
            catch (Exception ex)
            {
                Log.Fatal("Start log FATAL...");
            }
            return returnObject;
        }
    }
}
