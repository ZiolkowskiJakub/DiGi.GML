using DiGi.GML.CityGML.Classes;
using System;
using System.Xml;

namespace DiGi.GML.CityGML
{
    public static partial class Create
    {
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
