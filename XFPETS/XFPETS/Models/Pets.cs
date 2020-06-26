using System;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace XFPETS.Models
{
    public partial class Pets
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Image")]
        public Uri Image { get; set; }

        [JsonProperty("Breed")]
        public string Breed { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Location")]
        public string Location { get; set; }

        [JsonProperty("Size")]
        public string Size { get; set; }

        [JsonProperty("Gender")]
        public string Gender { get; set; }

        [JsonProperty("Health")]
        public string Health { get; set; }

        [JsonProperty("Meet")]
        public string Meet { get; set; }

        [JsonProperty("Social")]
        public string Social { get; set; }

        [JsonProperty("Url")]
        public string Url { get; set; }

    }

    public partial class Pets
    {
        public static Pets[] FromJson(string json) => JsonConvert.DeserializeObject<Pets[]>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Pets[] self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
