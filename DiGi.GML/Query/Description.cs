using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace DiGi.GML
{
    public static partial class Query
    {
        public static string Description(this Enum @enum)
        {
            Type type = @enum.GetType();

            Type type_Temp = Nullable.GetUnderlyingType(type);
            if(type_Temp != null)
            {
                type = type_Temp;
            }

            FieldInfo fieldInfo = type.GetField(@enum.ToString());

            DescriptionAttribute[] descriptionAttributes = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

            if (descriptionAttributes != null && descriptionAttributes.Any())
            {
                return descriptionAttributes[0].Description;
            }

            return @enum.ToString();
        }
    }
}