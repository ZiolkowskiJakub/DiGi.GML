using DiGi.GML.Interfaces;
using System;
using System.Collections;
using System.Globalization;
using System.Reflection;

namespace DiGi.GML
{
    public static partial class Query
    {
        /// <summary>
        /// Attempts to convert a string representation of a value to an object based on the provided property information.
        /// </summary>
        /// <param name="text">The string input to be converted.</param>
        /// <param name="propertyInfo">The property whose type determines the target conversion type.</param>
        /// <param name="value">When this method returns, contains the converted value if successful; otherwise, null.</param>
        /// <returns>True if the conversion was successful; otherwise, false.</returns>
        public static bool TryConvert(string? text, PropertyInfo? propertyInfo, out object? value)
        {
            return TryConvert(text, propertyInfo?.PropertyType, out value);
        }

        /// <summary>
        /// Attempts to convert a string representation of a value to an object of the specified type.
        /// </summary>
        /// <param name="text">The string input to be converted.</param>
        /// <param name="type">The target type for conversion.</param>
        /// <param name="value">When this method returns, contains the converted value if successful; otherwise, null.</param>
        /// <returns>True if the conversion was successful; otherwise, false.</returns>
        public static bool TryConvert(string? text, Type? type, out object? value)
        {
            value = null;
            if (type == null)
            {
                return false;
            }

            bool nullable = true;
            Type type_Temp = Nullable.GetUnderlyingType(type);
            if (type_Temp == null)
            {
                type_Temp = type;
                nullable = false;
            }

            if (type_Temp == typeof(string))
            {
                value = text;
                return true;
            }
            else if (type_Temp.IsEnum)
            {
                if (TryGetEnum(text, type_Temp, out Enum? @enum))
                {
                    value = @enum;
                    return true;
                }
            }
            else if (type_Temp == typeof(ushort))
            {
                if (ushort.TryParse(text, out ushort @short))
                {
                    value = nullable ? @short as ushort? : @short;
                    return true;
                }
            }
            else if (type_Temp == typeof(short))
            {
                if (short.TryParse(text, out short @short))
                {
                    value = nullable ? @short as short? : @short;
                    return true;
                }
            }
            else if (type_Temp == typeof(uint))
            {
                if (uint.TryParse(text, out uint @uint))
                {
                    value = nullable ? @uint as uint? : @uint;
                    return true;
                }
            }
            else if (type_Temp == typeof(int))
            {
                if (int.TryParse(text, out int @int))
                {
                    value = nullable ? @int as int? : @int;
                    return true;
                }
            }
            else if (type_Temp == typeof(DateTime))
            {
                if (DateTime.TryParse(text, out DateTime dateTime))
                {
                    value = nullable ? dateTime as DateTime? : dateTime;
                    return true;
                }
            }
            else if (type_Temp == typeof(double))
            {
                if (double.TryParse(text, NumberStyles.Any, CultureInfo.CurrentCulture, out double @double))
                {
                    value = nullable ? @double as double? : @double;
                    return true;
                }
                else if (double.TryParse(text, NumberStyles.Any, CultureInfo.InvariantCulture, out @double))
                {
                    value = nullable ? @double as double? : @double;
                    return true;
                }
            }
            else if (typeof(IList).IsAssignableFrom(type_Temp))
            {
                if (text != null && type_Temp.GenericTypeArguments.Length != 0)
                {
                    Type genericType = type.GenericTypeArguments[0];

                    string[] texts = genericType == typeof(double) ? text.Split(' ') : text.Split('\t');

                    if (Activator.CreateInstance(type) is IList list)
                    {
                        foreach (string text_Temp in texts)
                        {
                            if (TryConvert(text_Temp, genericType, out object? value_Temp))
                            {
                                list.Add(value_Temp);
                            }
                        }
                        value = list;
                        return true;
                    }
                }
            }
            else if (typeof(IAbstractGML).IsAssignableFrom(type_Temp))
            {
                throw new NotImplementedException();
            }
            else
            {
                throw new NotImplementedException();
            }

            return false;
        }
    }
}
