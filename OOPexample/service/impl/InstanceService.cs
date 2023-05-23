namespace Task1.service.impl
{
    public static class InstanceService
    {
        // Task 2.1 Returns instances of all classes of type T
        public static IEnumerable<T> GetInstances<T>()
        {

            var interfaceType = typeof(T);
            List<T> list = new List<T>();
            Console.WriteLine("Interface type: " + interfaceType.ToString());
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (var assembly in assemblies)
            {
                Console.WriteLine("Assembly: " + assembly.ToString());
                if (assembly.GetType().IsAbstract)
                {
                    var instance = (T)Activator.CreateInstance(assembly.GetType());
                    list.Add(instance);
                }
            }

            return list;
        }

        // Task 3.3 Writes all instances returned from GetInstances<T>() to disk.
        public static void ExportToTextFile<T>(this IEnumerable<T> list, string FileName, char ColumnSeperator)
        {
            using (var sw = File.CreateText(FileName))
            {
                var plist = typeof(T).GetProperties().Where(p => p.CanRead && (p.PropertyType.IsValueType || p.PropertyType == typeof(string)) && p.GetIndexParameters().Length == 0).ToList();
                if (plist.Count > 0)
                {
                    var seperator = ColumnSeperator.ToString();
                    sw.WriteLine(string.Join(seperator, plist.Select(p => p.Name)));
                    foreach (var item in list)
                    {
                        var values = new List<object>();
                        foreach (var p in plist) values.Add(p.GetValue(item, null));
                        sw.WriteLine(string.Join(seperator, values));
                    }

                }
            }
            Console.WriteLine("Done. File has been created with path: " + FileName + '\n' + "");

            // Read this file in console

            Console.WriteLine("Read created file:" + '\n' + "" + File.ReadAllText(FileName));
            }
        }
    }




