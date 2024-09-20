using System.Collections.Generic;
using System.Reflection;
using System.Xml;
using System.Linq;
using DiGi.GML.Interfaces;
using System.Collections;
using System;

namespace DiGi.GML
{
    public static partial class Modify
    {
        public static bool Update(this IAbstractGML abstractGML, XmlNode xmlNode)
        {
            if (xmlNode == null || abstractGML == null)
            {
                return false;
            }

            Dictionary<string, List<XmlNode>> dictionary_XmlNodes = new Dictionary<string, List<XmlNode>>();
            if(xmlNode.HasChildNodes)
            {
                foreach (XmlNode xmlNode_Child in xmlNode.ChildNodes)
                {
                    string name = xmlNode_Child?.LocalName;

                    if (string.IsNullOrWhiteSpace(name))
                    {
                        continue;
                    }

                    if (!dictionary_XmlNodes.TryGetValue(name, out List<XmlNode> xmlNodes) || xmlNodes == null)
                    {
                        xmlNodes = new List<XmlNode>();
                        dictionary_XmlNodes[name] = xmlNodes;
                    }

                    xmlNodes.Add(xmlNode_Child);
                }
            }


            Dictionary<string, XmlAttribute> dictionary_XmlAttribute = new Dictionary<string, XmlAttribute>();
            if(xmlNode.Attributes != null)
            {
                foreach(XmlAttribute xmlAttribute in xmlNode.Attributes)
                {
                    string name = xmlAttribute?.LocalName;

                    if (string.IsNullOrWhiteSpace(name))
                    {
                        continue;
                    }

                    dictionary_XmlAttribute[name] = xmlAttribute; 
                }
            }

            List<PropertyInfo> propertyInfos = abstractGML.GetType().GetProperties()?.ToList();
            if (propertyInfos == null || propertyInfos.Count == 0)
            {
                return false;
            }

            bool result = false;
            foreach (PropertyInfo propertyInfo in propertyInfos)
            {
                if (dictionary_XmlAttribute.TryGetValue(propertyInfo.Name, out XmlAttribute xmlAttribute) && xmlAttribute != null)
                {
                    object value = null;

                    if (!Query.TryConvert(xmlAttribute.Value, propertyInfo, out value))
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

                    object value = null;

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
                        else if (typeof(IEnumerable).IsAssignableFrom(type))
                        {
                            IList list = Activator.CreateInstance(type) as IList;
                            if (list != null)
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
    }
}