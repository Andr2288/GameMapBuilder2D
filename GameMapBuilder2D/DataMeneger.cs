using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace GameMapBuilder2D
{
    public static class DataManager
    {
        public static TileMapConfig ReadJsonFileElements(string jsonFilePath)
        {
            string jsonString = System.IO.File.ReadAllText(jsonFilePath);
            TileMapConfig allUsers = JsonConvert.DeserializeObject<TileMapConfig>(jsonString);

            return allUsers;
        }

        public static void WriteJsonFileElements(TileMapConfig elements, string jsonFilePath)
        {
            string json = JsonConvert.SerializeObject(elements, Formatting.Indented);

            // Збережіть рядок JSON у файл
            File.WriteAllText(jsonFilePath, json);
        }
    }
}
