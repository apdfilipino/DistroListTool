using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DistroListTool.Models
{
    public class DistroListItem
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("to")]
        public List<string> To { get; set; }

        [JsonPropertyName("subject")]
        public string Subject { get; set; }

        [JsonPropertyName("body")]
        public string Body { get; set; }

        [JsonPropertyName("htmlFormat")]
        public bool HtmlFormat { get; set; }

        [JsonIgnore]
        public string Recepients => string.Join(";", To);
    }
}
