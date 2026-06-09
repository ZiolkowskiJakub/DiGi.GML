using DiGi.GML.CityGML.Classes;
using System.IO;
using System.Xml;

namespace DiGi.GML.CityGML
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a CityGML file from the specified file path to a <see cref="CityModel"/> object.
        /// </summary>
        /// <param name="path">The file system path to the XML file.</param>
        /// <returns>A <see cref="CityModel"/> instance if the conversion is successful; otherwise, null.</returns>
        public static CityModel ToGML(string path)
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

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(text);

            return ToGML(xmlDocument);
        }

        /// <summary>
        /// Converts a CityGML stream to a <see cref="CityModel"/> object.
        /// </summary>
        /// <param name="steam">The input stream containing the XML data.</param>
        /// <returns>A <see cref="CityModel"/> instance if the conversion is successful; otherwise, null.</returns>
        public static CityModel ToGML(Stream steam)
        {
            if (steam == null)
            {
                return null;
            }

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(steam);

            return ToGML(xmlDocument);
        }

        /// <summary>
        /// Converts an <see cref="XmlDocument"/> to a <see cref="CityModel"/> object.
        /// </summary>
        /// <param name="xmlDocument">The XML document containing the GML data.</param>
        /// <returns>A <see cref="CityModel"/> instance if the conversion is successful; otherwise, null.</returns>
        public static CityModel ToGML(XmlDocument xmlDocument)
        {
            if (xmlDocument == null || !xmlDocument.HasChildNodes)
            {
                return null;
            }

            XmlNodeList xmlNodeList = xmlDocument.ChildNodes;
            if (xmlNodeList == null)
            {
                return new CityModel();
            }

            int count = xmlNodeList.Count;
            if (count == 0)
            {
                return new CityModel();
            }

            CityModel result = null;

            for (int i = 0; i < xmlNodeList.Count; i++)
            {
                string name = xmlNodeList[i]?.LocalName;

                if (string.IsNullOrWhiteSpace(name) || name == "xml")
                {
                    //return;
                    continue;
                }

                result = Create.CityModel(xmlNodeList[i]);
                if(result != null)
                {
                    break;
                }

            }

            return result;
        }
    }
}
