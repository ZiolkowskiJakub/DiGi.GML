using System;

namespace DiGi.GML
{
    public static partial class Query
    {
        public static bool TryGetEnum<T>(this string text, out T @enum) where T : Enum
        {
            Enum @enum_Temp;
            bool result = TryGetEnum(text, typeof(T), out @enum_Temp);
            @enum = (T)enum_Temp;

            return result;
        }

        public static bool TryGetEnum(this string text, Type type, out Enum @enum)
        {
            @enum = default;

            if (!type.IsEnum)
            {
                return false;
            }

            Array array = Enum.GetValues(type);
            if (array == null || array.Length == 0)
                return false;

            string text_Temp = null;
            foreach (Enum enum_Temp in array)
            {
                text_Temp = Description(enum_Temp).Trim();
                if (text_Temp.Equals(text))
                {
                    @enum = enum_Temp;
                    return true; ;
                }

            }

            return false;
        }
    }
}