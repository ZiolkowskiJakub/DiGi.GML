using DiGi.GML.Interfaces;
using System.Collections.Generic;
using System.Reflection;

namespace DiGi.GML
{
    public static partial class Query
    {
        public static Dictionary<string, PropertyInfo> PropertyInfoDictionary(this IAbstractGML abstractGML)
        { 
            if(abstractGML == null)
            {
                return null;
            }

            List<PropertyInfo> propertyInfos = abstractGML.PropertyInfos();
            if(propertyInfos == null)
            {
                return null;
            }

            Dictionary<string, PropertyInfo> result = new Dictionary<string, PropertyInfo>();
            foreach (PropertyInfo propertyInfo in propertyInfos) 
            {
                result[propertyInfo.Name] = propertyInfo;
            }

            return result;
        }
    }
}