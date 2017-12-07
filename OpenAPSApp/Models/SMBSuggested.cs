// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using OpenAPSApp;
//
//    var data = SMBSuggested.FromJson(jsonString);
//
namespace OpenAPSApp
{
    using System;
    using System.Net;
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public partial class SMBSuggested
    {
        [JsonProperty("bg")]
        public long Bg { get; set; }

        [JsonProperty("COB")]
        public long COB { get; set; }

        [JsonProperty("deliverAt")]
        public string DeliverAt { get; set; }

        [JsonProperty("duration")]
        public long Duration { get; set; }

        [JsonProperty("eventualBG")]
        public long EventualBG { get; set; }

        [JsonProperty("IOB")]
        public double IOB { get; set; }

        [JsonProperty("insulinReq")]
        public double InsulinReq { get; set; }

        [JsonProperty("predBGs")]
        public PredBGs PredBGs { get; set; }

        [JsonProperty("rate")]
        public double Rate { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("reservoir")]
        public string Reservoir { get; set; }

        [JsonProperty("sensitivityRatio")]
        public long SensitivityRatio { get; set; }

        [JsonProperty("temp")]
        public string Temp { get; set; }

        [JsonProperty("tick")]
        public double Tick { get; set; }
    }

    public partial class PredBGs
    {
        [JsonProperty("IOB")]
        public List<long> IOB { get; set; }

        [JsonProperty("UAM")]
        public List<long> UAM { get; set; }

        [JsonProperty("ZT")]
        public List<long> ZT { get; set; }
    }

    public partial class SMBSuggested
    {
        public static SMBSuggested FromJson(string json) => JsonConvert.DeserializeObject<SMBSuggested>(json, Converter.Settings);
    }
}