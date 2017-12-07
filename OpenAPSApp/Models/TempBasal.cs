// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using OpenAPSApp;
//
//    var data = TempBasal.FromJson(jsonString);
//
namespace OpenAPSApp
{
    using System;
    using System.Net;
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public partial class TempBasal
    {
        [JsonProperty("duration")]
        public long Duration { get; set; }

        [JsonProperty("rate")]
        public double Rate { get; set; }

        [JsonProperty("temp")]
        public string Temp { get; set; }
    }

    public partial class TempBasal
    {
        public static TempBasal FromJson(string json) => JsonConvert.DeserializeObject<TempBasal>(json, Converter.Settings);
    }

   
}
