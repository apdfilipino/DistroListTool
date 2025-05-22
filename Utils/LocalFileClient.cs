using System.IO;
using System.Text.Json;


namespace DistroListTool.Utils
{
    public class LocalFileClient
    {
        protected T LoadFile<T>(string path)
        {
            var lines = File.ReadAllLines(path);
            var json = string.Join("\n", lines);
            var serialized = JsonSerializer.Deserialize<T>(json);
            return serialized;
        }
    }
}
