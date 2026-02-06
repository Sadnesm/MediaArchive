using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace MediaArchive
{
    public static class StorageService
    {
        private const string FileName = "library.json";

        public static void Save(List<MediaItem> items)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(items, options);
            File.WriteAllText(FileName, json);
        }

        public static List<MediaItem> Load()
        {
            if (!File.Exists(FileName)) return new List<MediaItem>();
            try
            {
                string json = File.ReadAllText(FileName);
                return JsonSerializer.Deserialize<List<MediaItem>>(json) ?? new List<MediaItem>();
            }
            catch { return new List<MediaItem>(); }
        }
    }
}