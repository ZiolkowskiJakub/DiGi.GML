using DiGi.GML.Interfaces;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace DiGi.GML
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts an XML file at the specified path to a list of GML objects of type <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The type of GML object, which must implement <see cref="IAbstractGML"/>.</typeparam>
        /// <param name="path">The file path to the XML source.</param>
        /// <returns>A list of objects of type <typeparamref name="T"/> if successful; otherwise, null.</returns>
        public static List<T>? ToGML<T>(string? path) where T : IAbstractGML
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                return null;
            }

            string text = File.ReadAllText(path);
            if (string.IsNullOrWhiteSpace(text))
            {
                return null;
            }

            XmlDocument xmlDocument = new();
            xmlDocument.LoadXml(text);

            return ToGML<T>(xmlDocument);
        }

        /// <summary>
        /// Converts an XML stream to a list of GML objects of type <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The type of GML object, which must implement <see cref="IAbstractGML"/>.</typeparam>
        /// <param name="stream">The input stream containing the XML data.</param>
        /// <returns>A list of objects of type <typeparamref name="T"/> if successful; otherwise, null.</returns>
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

        /// <summary>
        /// Converts an <see cref="XmlDocument"/> to a list of GML objects of type <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The type of GML object, which must implement <see cref="IAbstractGML"/>.</typeparam>
        /// <param name="xmlDocument">The XML document to be converted.</param>
        /// <returns>A list of objects of type <typeparamref name="T"/> if successful; otherwise, null.</returns>
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
