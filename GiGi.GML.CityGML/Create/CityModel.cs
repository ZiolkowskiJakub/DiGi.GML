using DiGi.GML.CityGML.Classes;
using System;
using System.Xml;

namespace DiGi.GML.CityGML
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a <see cref="CityModel"/> instance from the provided <see cref="XmlNode"/>.
        /// </summary>
        /// <param name="xmlNode">The XML node to be processed into a city model.</param>
        /// <returns>A <see cref="CityModel"/> object if the node is valid and a corresponding type is found; otherwise, the default value.</returns>
        public static CityModel CityModel(this XmlNode xmlNode)
        {
            if (xmlNode == null)
            {
                return default;
            }

            Type type = Settings.TypeManager.GetType(xmlNode.LocalName);
            if (type == null)
            {
                return default;
            }

            CityModel result = Activator.CreateInstance(type) as CityModel;
            //Modify.Update(result, xmlNode);

            return result;
        }
    }
}
