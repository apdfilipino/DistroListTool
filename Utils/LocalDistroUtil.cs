using System.Threading.Tasks;
using DistroListTool.Interfaces;
using DistroListTool.Models;

namespace DistroListTool.Utils
{
    public class LocalDistroUtil : LocalFileClient, IDistroRepo
    {
        public Task<DistroConfig> GetDistroListsAsync(string path)
        {
            try
            {
                var serialized = LoadFile<DistroConfig>(path);
                return Task.FromResult(serialized);
            }
            catch
            {
                return null;
            }
        }
    }
}
