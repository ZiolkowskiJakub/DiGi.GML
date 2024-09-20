using DiGi.GML.Interfaces;
using System;
using System.Collections;
using System.Reflection;

namespace DiGi.GML
{
    public static partial class Query
    {
        public static bool TryConvert(string text, PropertyInfo propertyInfo, out object value)
        {
            return TryConvert(text, propertyInfo?.PropertyType, out value);
        }

        public static bool TryConvert(string text, Type type, out object value)
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
                if (TryGetEnum(text, type_Temp, out Enum @enum))
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
                if (double.TryParse(text, out double @double))
                {
                    value = nullable ? @double as double? : @double;
                    return true;
                }
            }
            else if (typeof(IEnumerable).IsAssignableFrom(type_Temp))
            {
                if (text != null && type_Temp.GenericTypeArguments.Length != 0)
                {  
                    Type genericType = type.GenericTypeArguments[0];

                    string[] texts = genericType == typeof(double) ? text.Split(' ') : text.Split('\t');

                    IList list = Activator.CreateInstance(type) as IList;
                    if (list != null)
                    {
                        foreach (string text_Temp in texts)
                        {
                            if (TryConvert(text_Temp, genericType, out object value_Temp))
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