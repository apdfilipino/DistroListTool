using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DistroListTool.Models
{
    public class DistroList
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("distros")]
        public List<DistroListItem> Distros { get; set; }
    }
}
