using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using DistroListTool.Interfaces;
using DistroListTool.Models;

namespace DistroListTool.Utils
{
    public class OnlineDistroUtil: OnlineFileClient, IDistroRepo
    {
        public async Task<DistroConfig> GetDistroListsAsync(string path)
        {
            var response = await _client.GetAsync(path).ConfigureAwait(false);

            var content = await response.Content.ReadAsStringAsync();
            var config = JsonSerializer.Deserialize<DistroConfig>(content);
            return config;
        }
    }
}
