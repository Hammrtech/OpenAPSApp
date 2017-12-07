// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using OpenAPSApp;
//
//    var data = IOB.FromJson(jsonString);
//
namespace OpenAPSApp
{
    using System;
    using System.Net;
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public partial class IOB
    {
        [JsonProperty("activity")]
        public double Activity { get; set; }

        [JsonProperty("basaliob")]
        public double Basaliob { get; set; }

        [JsonProperty("bolusinsulin")]
        public double Bolusinsulin { get; set; }

        [JsonProperty("bolusiob")]
        public double Bolusiob { get; set; }

        [JsonProperty("iob")]
        public double Iob { get; set; }

        [JsonProperty("iobWithZeroTemp")]
        public IobWithZeroTemp IobWithZeroTemp { get; set; }

        [JsonProperty("lastBolusTime")]
        public long? LastBolusTime { get; set; }

        [JsonProperty("lastTemp")]
        public LastTemp LastTemp { get; set; }

        [JsonProperty("netbasalinsulin")]
        public double Netbasalinsulin { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }
    }

    public partial class LastTemp
    {
        [JsonProperty("date")]
        public long Date { get; set; }

        [JsonProperty("duration")]
        public double Duration { get; set; }

        [JsonProperty("rate")]
        public double Rate { get; set; }

        [JsonProperty("started_at")]
        public string StartedAt { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public partial class IobWithZeroTemp
    {
        [JsonProperty("activity")]
        public double Activity { get; set; }

        [JsonProperty("basaliob")]
        public double Basaliob { get; set; }

        [JsonProperty("bolusinsulin")]
        public double Bolusinsulin { get; set; }

        [JsonProperty("bolusiob")]
        public double Bolusiob { get; set; }

        [JsonProperty("iob")]
        public double Iob { get; set; }

        [JsonProperty("netbasalinsulin")]
        public double Netbasalinsulin { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }
    }

    public partial class IOB
    {
        public static List<IOB> FromJson(string json) => JsonConvert.DeserializeObject<List<IOB>>(json, Converter.Settings);
    }
}
