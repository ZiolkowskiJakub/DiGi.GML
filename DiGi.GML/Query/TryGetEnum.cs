using System;

namespace DiGi.GML
{
    public static partial class Query
    {
        /// <summary>
        /// Attempts to convert a string representation to an enumeration value of type T based on the member's description.
        /// </summary>
        /// <typeparam name="T">The enumeration type.</typeparam>
        /// <param name="text">The string text to be converted.</param>
        /// <param name="enum">When this method returns, contains the enumeration value if conversion succeeded, or the default value otherwise.</param>
        /// <returns>True if the conversion was successful; otherwise, false.</returns>
        public static bool TryGetEnum<T>(this string? text, out T? @enum) where T : Enum
        {
            bool result = TryGetEnum(text, typeof(T), out Enum? enum_Temp);

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

        /// <summary>
        /// Attempts to convert a string representation to an enumeration value of the specified type based on the member's description.
        /// </summary>
        /// <param name="text">The string text to be converted.</param>
        /// <param name="type">The Type object that represents the enumeration type.</param>
        /// <param name="enum">When this method returns, contains the enumeration value if conversion succeeded, or the default value otherwise.</param>
        /// <returns>True if the conversion was successful; otherwise, false.</returns>
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
                if (text_Temp.Equals(text, StringComparison.Ordinal))
                {
                    @enum = enum_Temp;
                    return true;
                }
            }

            return false;
        }
    }
}
