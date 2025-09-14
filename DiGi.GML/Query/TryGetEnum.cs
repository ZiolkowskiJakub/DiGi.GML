using System;

namespace DiGi.GML
{
    public static partial class Query
    {
        public static bool TryGetEnum<T>(this string? text, out T? @enum) where T : Enum
        {
            bool result = TryGetEnum(text, typeof(T), out Enum? @enum_Temp);

            if (enum_Temp is T t)
            {
                @enum = t;
            }
            else
            {
                result = false;
                @enum = default;
            }

            return result;
        }

        public static bool TryGetEnum(this string? text, Type? type, out Enum? @enum)
        {
            @enum = default;

            if (string.IsNullOrWhiteSpace(text) || type is null || !type.IsEnum)
            {
                return false;
            }

            Array? array = Enum.GetValues(type);
            if (array == null || array.Length == 0)
            {
                return false;
            }

            foreach (Enum enum_Temp in array)
            {
                string? text_Temp = Description(enum_Temp).Trim();
                if (text_Temp.Equals(text))
                {
                    @enum = enum_Temp;
                    return true;
                }
            }

            return false;
        }
    }
}