using System.Text.Json.Serialization;

namespace DistroListTool.Models
{
    public class Config
    {
        [JsonPropertyName("path")]
        public string Path { get; set; }

        [JsonPropertyName("isLocal")]
        public bool IsLocal { get; set; }
    }
}
