using DiGi.GML.Classes;
using DiGi.GML.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Xml;

namespace DiGi.GML
{
    public static partial class Modify
    {
        /// <summary>
        /// Updates the properties of an <see cref="IAbstractGML"/> instance based on the values provided in an <see cref="XmlNode"/>.
        /// </summary>
        /// <param name="abstractGML">The GML object to be updated.</param>
        /// <param name="xmlNode">The XML node containing the source data for the update.</param>
        /// <returns>True if at least one property was successfully updated; otherwise, false.</returns>
        public static bool Update(this IAbstractGML abstractGML, XmlNode xmlNode)
        {
            if (xmlNode == null || abstractGML == null)
            {
                return false;
            }

            Dictionary<string, List<XmlNode>> dictionary_XmlNodes = [];
            if (xmlNode.HasChildNodes)
            {
                foreach (XmlNode xmlNode_Child in xmlNode.ChildNodes)
                {
                    string? name = xmlNode_Child?.LocalName;

                    if (string.IsNullOrWhiteSpace(name))
                    {
                        continue;
                    }

                    if (!dictionary_XmlNodes.TryGetValue(name!, out List<XmlNode> xmlNodes) || xmlNodes == null)
                    {
                        xmlNodes = [];
                        dictionary_XmlNodes[name!] = xmlNodes;
                    }

                    xmlNodes.Add(xmlNode_Child!);
                }
            }

            Dictionary<string, XmlAttribute> dictionary_XmlAttribute = [];
            if (xmlNode.Attributes != null)
            {
                foreach (XmlAttribute xmlAttribute in xmlNode.Attributes)
                {
                    string? name = xmlAttribute?.LocalName;

                    if (string.IsNullOrWhiteSpace(name))
                    {
                        continue;
                    }

                    dictionary_XmlAttribute[name!] = xmlAttribute!;
                }
            }

            List<PropertyInfo>? propertyInfos = Query.PropertyInfos(abstractGML);
            if (propertyInfos == null || propertyInfos.Count == 0)
            {
                return false;
            }

            bool result = false;
            foreach (PropertyInfo propertyInfo in propertyInfos)
            {
                if (dictionary_XmlAttribute.TryGetValue(propertyInfo.Name, out XmlAttribute xmlAttribute) && xmlAttribute != null)
                {
                    if (!Query.TryConvert(xmlAttribute.Value, propertyInfo, out object? value))
                    {
                        continue;
                    }

                    propertyInfo.SetValue(abstractGML, value);
                    result = true;
                    continue;
                }

                if (dictionary_XmlNodes.TryGetValue(propertyInfo.Name, out List<XmlNode> xmlNodes) && xmlNodes != null && xmlNodes.Count != 0)
                {
                    if (!xmlNodes.TrueForAll(x => x.HasChildNodes))
                    {
                        continue;
                    }

                    object? value = null;

                    List<XmlNode> xmlNodes_Temp = xmlNodes.ConvertAll(x => x.ChildNodes[0]);
                    if (xmlNodes_Temp.TrueForAll(x => x is XmlText))
                    {
                        string text = string.Join("\t", xmlNodes.ConvertAll(x => x.InnerText));

                        if (!Query.TryConvert(text, propertyInfo, out value))
                        {
                            continue;
                        }
                    }
                    else
                    {
                        Type type = propertyInfo.PropertyType;
                        Type type_Temp = Nullable.GetUnderlyingType(type);
                        if (type_Temp != null)
                        {
                            type = type_Temp;
                        }

                        if (typeof(IAbstractGML).IsAssignableFrom(type))
                        {
                            if (xmlNodes.Count == 1)
                            {
                                value = Create.AbstractGML(xmlNodes_Temp[0]);
                            }
                        }
                        else if (typeof(IList).IsAssignableFrom(type))
                        {
                            if (Activator.CreateInstance(type) is IList list)
                            {
                                foreach (XmlNode xmlNode_Temp in xmlNodes_Temp)
                                {
                                    list.Add(Create.AbstractGML(xmlNode_Temp));
                                }

                                value = list;
                            }
                            else
                            {
                                throw new NotImplementedException();
                            }
                        }
                        else
                        {
                            throw new NotImplementedException();
                        }
                    }

                    propertyInfo.SetValue(abstractGML, value);
                    result = true;
                }
            }

            return result;
        }

        /// <summary>
        /// Updates the properties of a destination GML object using values from a source GML object of the same type.
        /// </summary>
        /// <typeparam name="T">A type that implements <see cref="IAbstractGML"/>.</typeparam>
        /// <param name="abstractGML_Source">The source GML object containing the data to copy.</param>
        /// <param name="abstractGML_Destination">The destination GML object to be updated.</param>
        /// <returns>True if the update process completed; otherwise, false.</returns>
        public static bool Update<T>(this T abstractGML_Source, T abstractGML_Destination) where T : IAbstractGML
        {
            if (abstractGML_Source == null || abstractGML_Destination == null)
            {
                return false;
            }

            List<PropertyInfo>? propertyInfos = abstractGML_Destination.PropertyInfos();
            if (propertyInfos == null || propertyInfos.Count == 0)
            {
                return true;
            }

            foreach (PropertyInfo propertyInfo in propertyInfos)
            {
                Update(abstractGML_Source, abstractGML_Destination, propertyInfo);
            }

            return true;
        }

        /// <summary>
        /// Updates a specific property of a destination GML object using the value from the corresponding property of a source GML object.
        /// </summary>
        /// <typeparam name="T">A type that implements <see cref="IAbstractGML"/>.</typeparam>
        /// <param name="abstractGML_Source">The source GML object containing the data to copy.</param>
        /// <param name="abstractGML_Destination">The destination GML object to be updated.</param>
        /// <param name="propertyInfo">The property information of the member to be updated.</param>
        /// <returns>True if the property was successfully updated; otherwise, false.</returns>
        public static bool Update<T>(this T abstractGML_Source, T abstractGML_Destination, PropertyInfo propertyInfo)
        {
            if (abstractGML_Source == null || abstractGML_Source == null)
            {
                return false;
            }

            object? value = propertyInfo.GetValue(abstractGML_Source);

            if (value is IAbstractGML)
            {
                value = ((AbstractGML)value).Clone();
            }
            else if (value is string)
            {
            }
            else if (value is IList)
            {
                if (Activator.CreateInstance(value.GetType()) is not IList list)
                {
                    return false;
                }

                foreach (object @object in (IEnumerable)value)
                {
                    if (@object is IAbstractGML)
                    {
                        list.Add(((AbstractGML)@object).Clone());
                    }
                    else
                    {
                        list.Add(@object);
                    }
                }
                value = list;
            }

            propertyInfo.SetValue(abstractGML_Destination, value);
            return true;
        }
    }
}
