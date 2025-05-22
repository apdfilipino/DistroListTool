using System.Collections.Generic;
using System.Threading.Tasks;
using DistroListTool.Models;

namespace DistroListTool.Interfaces
{
    internal interface IDistroRepo
    {
        Task<DistroConfig> GetDistroListsAsync(string path);
    }
}
