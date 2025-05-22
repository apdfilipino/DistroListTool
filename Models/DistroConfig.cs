using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DistroListTool.Models
{
    public class DistroConfig
    {

        [JsonPropertyName("version")]
        public string Version { get; set; }

        [JsonPropertyName("distroList")]
        public List<DistroList> DistroList { get; set; }
    }
}
