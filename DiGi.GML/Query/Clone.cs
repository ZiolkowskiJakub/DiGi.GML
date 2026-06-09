using DiGi.GML.Interfaces;
using System;

namespace DiGi.GML
{
    public static partial class Query
    {
        /// <summary>
        /// Creates a clone of the specified GML object by instantiating a new instance of its type and copying its properties.
        /// </summary>
        /// <typeparam name="T">The type of the GML object, which must implement <see cref="IAbstractGML"/>.</typeparam>
        /// <param name="abstractGML">The source GML object to clone.</param>
        /// <returns>A new instance of type <typeparamref name="T"/> containing the cloned data, or <c>null</c> if the input is null or the type cannot be instantiated as <typeparamref name="T"/>.</returns>
        public static T? Clone<T>(this T? abstractGML) where T : IAbstractGML
        {
            if (abstractGML == null)
            {
                return default;
            }

            object @object = Activator.CreateInstance(abstractGML.GetType());
            if (@object is not T)
            {
                return default;
            }

            T result = (T)@object;

            Modify.Update(abstractGML, result);

            return result;
        }
    }
}
