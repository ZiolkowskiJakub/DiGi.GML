using DiGi.GML.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace DiGi.GML
{
    public static partial class Convert
    {
        public static List<T> ToGML<T>(string path) where T : IAbstractGML
        {
            if(string.IsNullOrWhiteSpace(path))
            {
                return null;
            }

            string text = System.IO.File.ReadAllText(path);
            if(string.IsNullOrWhiteSpace(text))
            {
                return null;
            }

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(text);

            if(!xmlDocument.HasChildNodes)
            {
                return null;
            }

            XmlNodeList xmlNodeList = xmlDocument.ChildNodes;
            if(xmlNodeList == null )
            {
                return new List<T>();
            }

            int count = xmlNodeList.Count;
            if(count == 0)
            {
                return new List<T>();
            }

            List<T> result = Enumerable.Repeat<T>(default, count).ToList();

            for(int i = 0; i < xmlNodeList.Count; i++)//Parallel.For(0, count, i => 
            {
                string name = xmlNodeList[i]?.LocalName;

                if (string.IsNullOrWhiteSpace(name) || name == "xml")
                {
                    //return;
                    continue;
                }

                IAbstractGML abstractGML = Create.AbstractGML(xmlNodeList[i]);
                if (!(abstractGML is T))
                {
                    //return;
                    continue;
                }

                result.Add((T)abstractGML);

            }//);

            result.RemoveAll(x => x == null);

            return result;
        }
    }
}