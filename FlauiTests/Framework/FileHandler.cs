using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace FlauiTests.Framework
{
    class FileHandler
    {
        public static string ReadJsonFile(string keyToFind, string filePath)
        {
            string valueToFind = null;
            try
            {
                string jsonString = File.ReadAllText(filePath, Encoding.GetEncoding("iso-8859-1"));
                var jsonObject = JsonSerializer.Deserialize<Dictionary<string, string>>(jsonString);
                jsonObject.TryGetValue(keyToFind, out valueToFind);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            return valueToFind;
        }

        public static string GetCurrentFolderPath()
        {
            var path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            var actualPath = path.Substring(0, path.LastIndexOf("bin"));
            var projectPath = new Uri(actualPath).LocalPath;
            return projectPath;
        }
    }
}
