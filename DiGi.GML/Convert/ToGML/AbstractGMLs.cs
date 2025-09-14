using DiGi.GML.Interfaces;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;

namespace DiGi.GML
{
    public static partial class Convert
    {
        public static List<T>? ToGML<T>(string? path) where T : IAbstractGML
        {
            if(string.IsNullOrWhiteSpace(path))
            {
                return null;
            }

            string text = File.ReadAllText(path);
            if(string.IsNullOrWhiteSpace(text))
            {
                return null;
            }

            XmlDocument xmlDocument = new();
            xmlDocument.LoadXml(text);

            return ToGML<T>(xmlDocument);
        }

        public static List<T>? ToGML<T>(Stream? stream) where T : IAbstractGML
        {
            if (stream == null)
            {
                return null;
            }

            XmlDocument xmlDocument = new();
            xmlDocument.Load(stream);

            return ToGML<T>(xmlDocument);
        }

        public static List<T>? ToGML<T>(XmlDocument? xmlDocument) where T : IAbstractGML
        {
            if (xmlDocument == null || !xmlDocument.HasChildNodes)
            {
                return null;
            }

            XmlNodeList xmlNodeList = xmlDocument.ChildNodes;
            if (xmlNodeList == null)
            {
                return [];
            }

            int count = xmlNodeList.Count;
            if (count == 0)
            {
                return [];
            }

            List<T> result = [];
            for (int i = 0; i < xmlNodeList.Count; i++)
            {
                string? name = xmlNodeList[i]?.LocalName;

                if (string.IsNullOrWhiteSpace(name) || name == "xml")
                {
                    continue;
                }

                IAbstractGML? abstractGML = Create.AbstractGML(xmlNodeList[i]);
                if (abstractGML is not T t)
                {
                    continue;
                }

                result.Add(t);

            }

            return result;
        }
    }
}