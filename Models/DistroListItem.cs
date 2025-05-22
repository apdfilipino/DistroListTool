using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DistroListTool.Models
{
    public class DistroListItem
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("to")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string> To { get; set; } = new List<string>();
    
        [JsonPropertyName("cc")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string> Cc { get; set; } = new List<string>();

        [JsonPropertyName("bcc")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string> Bcc { get; set; } = new List<string>();

        [JsonPropertyName("subject")]
        public string Subject { get; set; } = "";

        [JsonPropertyName("body")]
        public string Body { get; set; } = "";

        [JsonPropertyName("htmlFormat")]
        public bool HtmlFormat { get; set; } = false;

        [JsonIgnore]
        public string ToRecepients => GetRecipients(To);

        [JsonIgnore]
        public string CcRecepients => GetRecipients(Cc);

        [JsonIgnore]
        public string BccRecepients => GetRecipients(Bcc);

        public string GetRecipients(List<string> recipients) => recipients.Count > 0 ? string.Join(";", recipients): "";

    }
}
