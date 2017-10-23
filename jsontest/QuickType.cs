// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var data = GettingStarted.FromJson(jsonString);
//
namespace QuickType
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public partial class GettingStarted
    {
        [JsonProperty("createList")]
        public List<CreateList> CreateList { get; set; }

        [JsonProperty("emoteTable")]
        public List<EmoteTable> EmoteTable { get; set; }

        [JsonProperty("wcid")]
        public long Wcid { get; set; }

        [JsonProperty("weenieType")]
        public long WeenieType { get; set; }
    }

    public partial class CreateList
    {
        [JsonProperty("palette")]
        public long Palette { get; set; }

        [JsonProperty("stack_size")]
        public double StackSize { get; set; }

        [JsonProperty("destination")]
        public long Destination { get; set; }

        [JsonProperty("shade")]
        public double Shade { get; set; }

        [JsonProperty("try_to_bond")]
        public long TryToBond { get; set; }

        [JsonProperty("wcid")]
        public long Wcid { get; set; }
    }

    public partial class EmoteTable
    {
        [JsonProperty("key")]
        public long Key { get; set; }

        [JsonProperty("value")]
        public List<OtherValue> Value { get; set; }
    }

    public partial class OtherValue
    {
        [JsonProperty("emotes")]
        public List<Emote> Emotes { get; set; }

        [JsonProperty("category")]
        public long Category { get; set; }

        [JsonProperty("probability")]
        public double Probability { get; set; }

        [JsonProperty("vendorType")]
        public long VendorType { get; set; }
    }

    public partial class Emote
    {
        [JsonProperty("extent")]
        public long Extent { get; set; }

        [JsonProperty("msg")]
        public string Msg { get; set; }

        [JsonProperty("delay")]
        public long Delay { get; set; }

        [JsonProperty("motion")]
        public long? Motion { get; set; }

        [JsonProperty("type")]
        public long Type { get; set; }
    }


    public partial class GettingStarted
    {
        public static GettingStarted FromJson(string json) => JsonConvert.DeserializeObject<GettingStarted>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this GettingStarted self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    public class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
        };
    }
}
