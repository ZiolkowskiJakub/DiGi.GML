using DiGi.GML.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DiGi.GML.Classes
{
    public class TypeManager
    {
        private Dictionary<string, Type> dictionary = null;

        public TypeManager() 
        {

        }

        public Type GetType(string name, bool update = true)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                return null;
            }

            if(dictionary == null)
            {
                dictionary = new Dictionary<string, Type>();
            }

            if(dictionary.TryGetValue(name, out Type type))
            {
                return type;
            }

            Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (Assembly assembly in assemblies)
            {
                Type[] types = assembly.GetTypes();
                foreach (Type type_Temp in types)
                {
                    if (!typeof(IAbstractGML).IsAssignableFrom(type_Temp))
                    {
                        continue;
                    }

                    if(type_Temp.Name != name)
                    {
                        continue;
                    }

                    if(update)
                    {
                        dictionary[name] = type_Temp;
                    }

                    return type_Temp;
                }
            }

            if(update)
            {
                dictionary[name] = null;
            }

            return null;
        }
    }
}
