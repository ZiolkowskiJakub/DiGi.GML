using DiGi.GML.Interfaces;
using System;
using System.Xml;

namespace DiGi.GML
{
    public static partial class Create
    {
        public static IAbstractGML? AbstractGML(this XmlNode? xmlNode)
        {
            return AbstractGML<IAbstractGML>(xmlNode);
        }

        public static T? AbstractGML<T>(this XmlNode? xmlNode) where T : IAbstractGML
        {
            if (xmlNode == null)
            {
                return default;
            }

            Type? type = Settings.TypeManager.GetType(xmlNode.LocalName);
            if (type == null)
            {
                return default;
            }

            object? @object = Activator.CreateInstance(type);
            if(@object is not T t)
            {
                return default;
            }

            T? result = t;

            Modify.Update(result, xmlNode);

            return result;
        }
    }
}