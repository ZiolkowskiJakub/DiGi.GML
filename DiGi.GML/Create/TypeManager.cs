using DiGi.GML.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace DiGi.GML
{
    public static partial class Create
    {
        public static TypeManager TypeManager()
        {
            List<Assembly> assemblies_Loaded = AppDomain.CurrentDomain.GetAssemblies().ToList();
            string[] paths_LadedAssemblies = assemblies_Loaded.Select(x => x.Location).ToArray();
            IEnumerable<string> paths_Referenced = Assembly.GetEntryAssembly()?.GetReferencedAssemblies().Select(x => Assembly.Load(x).Location).ToArray() ?? Array.Empty<string>();

            List<string> paths_ToLoad = paths_Referenced.Where(x => !paths_LadedAssemblies.Contains(x)).ToList();

            string directory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            foreach (string path in Directory.GetFiles(directory, "*.dll"))
            {
                if(paths_LadedAssemblies.Contains(path))
                {
                    continue;
                }

                if(paths_ToLoad.Contains(path))
                {
                    continue;
                }

                paths_ToLoad.Add(path);
            }

            foreach (string path_ToLoad in paths_ToLoad)
            {
                try
                {
                    Assembly.LoadFrom(path_ToLoad);
                }
                catch
                {

                }

            }

            return new TypeManager();
        }
    }
}