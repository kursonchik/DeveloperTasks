using System.Text.Json;

namespace Task1.service.impl
{
    public static class InstanceService
    {

        // Task 2.1 Returns instances of all classes of type T 
        public static IEnumerable<T> GetInstances<T>()
        {
            var assembly = typeof(T).Assembly; 

            foreach (var type in assembly.GetTypes()) 
            {
                if (typeof(T).IsAssignableFrom(type))
                {
                    yield return (T)Activator.CreateInstance(type);

                }
            }
        }


        // Task 3.2 Search for types by specifying part of the name
        public static Type GetTypeByName(string namePart)
        {
            return AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(a => a.GetTypes())
                .FirstOrDefault(t => t.Name.IndexOf(namePart, StringComparison.OrdinalIgnoreCase) >= 0); //case-insensitive
        }


        // Task 3.3 Writes all instances returned from GetInstances<T>() to disk.
        public static void ExportToTextFile<T>(string fileName)
        {
            var instances = GetInstances<T>().ToList();

            using (var writer = new StreamWriter(fileName))
            {
                foreach (var instance in instances)
                {
                    var json = JsonSerializer.Serialize(instance);
                    writer.WriteLine(json);
                }
                
            }
            Console.WriteLine("Done. File has been created with path: " + fileName + '\n' + "");

            Console.WriteLine("Read created file:" + '\n' + "" + File.ReadAllText(fileName));
        }

    }
}




