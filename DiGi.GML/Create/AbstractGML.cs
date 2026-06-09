using DiGi.GML.Interfaces;
using System;
using System.Xml;

namespace DiGi.GML
{
    public static partial class Create
    {
        /// <summary>
        /// Creates an instance of a class implementing <see cref="IAbstractGML"/> based on the provided XML node.
        /// </summary>
        /// <param name="xmlNode">The XML node to be converted into an <see cref="IAbstractGML"/> object.</param>
        /// <returns>An implementation of <see cref="IAbstractGML"/> if successful; otherwise, null.</returns>
        public static IAbstractGML? AbstractGML(this XmlNode? xmlNode)
        {
            return AbstractGML<IAbstractGML>(xmlNode);
        }

        /// <summary>
        /// Creates an instance of a class implementing the specified generic type <typeparamref name="T"/> based on the provided XML node.
        /// </summary>
        /// <typeparam name="T">The specific type that implements <see cref="IAbstractGML"/>.</typeparam>
        /// <param name="xmlNode">The XML node to be converted into an object of type <typeparamref name="T"/>.</param>
        /// <returns>An instance of type <typeparamref name="T"/> if successful; otherwise, null.</returns>
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
            if (@object is not T t)
            {
                return default;
            }

            T? result = t;

            Modify.Update(result, xmlNode);

            return result;
        }
    }
}
