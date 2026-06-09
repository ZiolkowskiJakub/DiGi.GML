using DiGi.GML.Interfaces;
using System.Collections.Generic;
using System.Reflection;

namespace DiGi.GML
{
    public static partial class Query
    {
        /// <summary>
        /// Creates a dictionary of property information where the key is the name of the property and the value is the <see cref="PropertyInfo"/>.
        /// </summary>
        /// <param name="abstractGML">The abstract GML instance to extract property information from.</param>
        /// <returns>A dictionary containing the mapping of property names to their respective <see cref="PropertyInfo"/>, or null if the provided <paramref name="abstractGML"/> is null or contains no property information.</returns>
        public static Dictionary<string, PropertyInfo>? PropertyInfoDictionary(this IAbstractGML? abstractGML)
        {
            if (abstractGML == null)
            {
                return null;
            }

            List<PropertyInfo>? propertyInfos = abstractGML.PropertyInfos();
            if (propertyInfos == null)
            {
                return null;
            }

            Dictionary<string, PropertyInfo> result = [];
            foreach (PropertyInfo propertyInfo in propertyInfos)
            {
                result[propertyInfo.Name] = propertyInfo;
            }

            return result;
        }
    }
}
