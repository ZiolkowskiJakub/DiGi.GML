using System;
using System.ComponentModel;
using System.Reflection;

namespace DiGi.GML
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves the description of an enumeration value, prioritizing the value defined in the <see cref="DescriptionAttribute"/>.
        /// </summary>
        /// <param name="enum">The enumeration value to extract the description from.</param>
        /// <returns>The string value of the <see cref="DescriptionAttribute"/> if present; otherwise, the string representation of the enum member.</returns>
        public static string Description(this Enum @enum)
        {
            Type type = @enum.GetType();

            Type type_Temp = Nullable.GetUnderlyingType(type);
            if (type_Temp != null)
            {
                type = type_Temp;
            }

            FieldInfo fieldInfo = type.GetField(@enum.ToString());

            if (fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false) is DescriptionAttribute[] descriptionAttributes && descriptionAttributes.Length != 0)
            {
                return descriptionAttributes[0].Description;
            }

            return @enum.ToString();
        }
    }
}
