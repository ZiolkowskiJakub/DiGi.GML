using DiGi.GML.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DiGi.GML
{
    public static partial class Query
    {
        public static List<PropertyInfo> PropertyInfos(this IAbstractGML abstractGML)
        { 
            if(abstractGML == null)
            {
                return null;
            }

            return abstractGML.GetType().GetProperties()?.ToList();
        }
    }
}