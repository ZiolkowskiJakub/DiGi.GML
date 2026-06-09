using DiGi.GML.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DiGi.GML
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves a list of property information for the specified abstract GML object using reflection.
        /// </summary>
        /// <param name="abstractGML">The abstract GML instance to extract properties from.</param>
        /// <returns>A list of <see cref="PropertyInfo"/> objects if the input is not null; otherwise, null.</returns>
        public static List<PropertyInfo>? PropertyInfos(this IAbstractGML? abstractGML)
        {
            if (abstractGML == null)
            {
                return null;
            }

            return abstractGML.GetType().GetProperties()?.ToList();
        }
    }
}
