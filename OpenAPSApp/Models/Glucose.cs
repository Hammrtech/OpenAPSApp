// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using OpenAPSApp;
//
//    var data = Glucose.FromJson(jsonString);
//
namespace OpenAPSApp
{
    using System;
    using System.Net;
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public partial class Glucose
    {
        [JsonProperty("date")]
        public long Date { get; set; }

        [JsonProperty("dateString")]
        public string DateString { get; set; }

        [JsonProperty("device")]
        public string Device { get; set; }

        [JsonProperty("direction")]
        public string Direction { get; set; }

        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("glucose")]
        public long BloodGlucose { get; set; }

        [JsonProperty("sgv")]
        public long Sgv { get; set; }

        [JsonProperty("trend")]
        public long Trend { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class Glucose
    {
        public static Glucose FromJson(string json) => JsonConvert.DeserializeObject<Glucose>(json, Converter.Settings);
    }
}
