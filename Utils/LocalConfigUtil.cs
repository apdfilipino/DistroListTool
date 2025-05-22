using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using DistroListTool.Models;

namespace DistroListTool.Utils
{
    public class LocalConfigUtil: LocalFileClient
    {
        public async Task<Config> GetConfig(string path)
        {
            var config = LoadFile<Config>(path);
            return await Task.FromResult(config);
        }

        public void PersistConfig(string filePath, Config config)
        {
            File.WriteAllText(filePath, JsonSerializer.Serialize(config));
        }
    }
}
