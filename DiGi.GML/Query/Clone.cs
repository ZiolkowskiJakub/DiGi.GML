using DiGi.GML.Interfaces;
using System;

namespace DiGi.GML
{
    public static partial class Query
    {
        public static T Clone<T>(this T abstractGML) where T : IAbstractGML
        {
            if(abstractGML == null)
            {
                return default(T);
            }

            object @object = Activator.CreateInstance(abstractGML.GetType());
            if (!(@object is T))
            {
                return default;
            }

            T result = (T)@object;

            Modify.Update(abstractGML, result);

            return result;
        }
    }
}