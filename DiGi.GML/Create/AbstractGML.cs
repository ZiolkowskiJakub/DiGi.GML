using DiGi.GML.Interfaces;
using System;
using System.Xml;

namespace DiGi.GML
{
    public static partial class Create
    {
        public static IAbstractGML AbstractGML(this XmlNode xmlNode)
        {
            return AbstractGML<IAbstractGML>(xmlNode);
        }

        public static T AbstractGML<T>(this XmlNode xmlNode) where T : IAbstractGML
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

            object @object = Activator.CreateInstance(type);
            if(!(@object is T))
            {
                return default;
            }

            T result = (T)@object;

            Modify.Update(result, xmlNode);

            return result;
        }
    }
}