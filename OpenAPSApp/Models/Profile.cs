// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using OpenAPSApp;
//
//    var data = Profile.FromJson(jsonString);
//
namespace OpenAPSApp
{
    using System;
    using System.Net;
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public partial class Profile
    {
        [JsonProperty("adv_target_adjustments")]
        public bool AdvTargetAdjustments { get; set; }

        [JsonProperty("allowSMB_with_high_temptarget")]
        public bool AllowSMBWithHighTemptarget { get; set; }

        [JsonProperty("autosens_adjust_targets")]
        public bool AutosensAdjustTargets { get; set; }

        [JsonProperty("autosens_max")]
        public double AutosensMax { get; set; }

        [JsonProperty("autosens_min")]
        public double AutosensMin { get; set; }

        [JsonProperty("autotune_isf_adjustmentFraction")]
        public long AutotuneIsfAdjustmentFraction { get; set; }

        [JsonProperty("basalprofile")]
        public List<Basalprofile> Basalprofile { get; set; }

        [JsonProperty("bg_targets")]
        public BgTargets BgTargets { get; set; }

        [JsonProperty("bolussnooze_dia_divisor")]
        public long BolussnoozeDiaDivisor { get; set; }

        [JsonProperty("carb_ratio")]
        public double CarbRatio { get; set; }

        [JsonProperty("carb_ratios")]
        public CarbRatios CarbRatios { get; set; }

        [JsonProperty("carbratio_adjustmentratio")]
        public long CarbratioAdjustmentratio { get; set; }

        [JsonProperty("carbsReqThreshold")]
        public long CarbsReqThreshold { get; set; }

        [JsonProperty("current_basal")]
        public double CurrentBasal { get; set; }

        [JsonProperty("current_basal_safety_multiplier")]
        public long CurrentBasalSafetyMultiplier { get; set; }

        [JsonProperty("curve")]
        public string Curve { get; set; }

        [JsonProperty("dia")]
        public long Dia { get; set; }

        [JsonProperty("enableSMB_after_carbs")]
        public bool EnableSMBAfterCarbs { get; set; }

        [JsonProperty("enableSMB_always")]
        public bool EnableSMBAlways { get; set; }

        [JsonProperty("enableSMB_with_COB")]
        public bool EnableSMBWithCOB { get; set; }

        [JsonProperty("enableSMB_with_temptarget")]
        public bool EnableSMBWithTemptarget { get; set; }

        [JsonProperty("enableUAM")]
        public bool EnableUAM { get; set; }

        [JsonProperty("exercise_mode")]
        public bool ExerciseMode { get; set; }

        [JsonProperty("half_basal_exercise_target")]
        public long HalfBasalExerciseTarget { get; set; }

        [JsonProperty("insulinPeakTime")]
        public long InsulinPeakTime { get; set; }

        [JsonProperty("isfProfile")]
        public BgTargets IsfProfile { get; set; }

        [JsonProperty("max_basal")]
        public long MaxBasal { get; set; }

        [JsonProperty("max_bg")]
        public long MaxBg { get; set; }

        [JsonProperty("maxCOB")]
        public long MaxCOB { get; set; }

        [JsonProperty("max_daily_basal")]
        public double MaxDailyBasal { get; set; }

        [JsonProperty("max_daily_safety_multiplier")]
        public long MaxDailySafetyMultiplier { get; set; }

        [JsonProperty("max_iob")]
        public long MaxIob { get; set; }

        [JsonProperty("maxSMBBasalMinutes")]
        public long MaxSMBBasalMinutes { get; set; }

        [JsonProperty("min_5m_carbimpact")]
        public long Min5mCarbimpact { get; set; }

        [JsonProperty("min_bg")]
        public long MinBg { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("offline_hotspot")]
        public bool OfflineHotspot { get; set; }

        [JsonProperty("out_units")]
        public string OutUnits { get; set; }

        [JsonProperty("override_high_target_with_low")]
        public bool OverrideHighTargetWithLow { get; set; }

        [JsonProperty("remainingCarbsCap")]
        public long RemainingCarbsCap { get; set; }

        [JsonProperty("remainingCarbsFraction")]
        public long RemainingCarbsFraction { get; set; }

        [JsonProperty("rewind_resets_autosens")]
        public bool RewindResetsAutosens { get; set; }

        [JsonProperty("sens")]
        public double Sens { get; set; }

        [JsonProperty("unsuspend_if_no_temp")]
        public bool UnsuspendIfNoTemp { get; set; }

        [JsonProperty("useCustomPeakTime")]
        public bool UseCustomPeakTime { get; set; }
    }

    public partial class CarbRatios
    {
        [JsonProperty("first")]
        public long First { get; set; }

        [JsonProperty("raw")]
        public string Raw { get; set; }

        [JsonProperty("schedule")]
        public List<Schedule> Schedule { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    public partial class Schedule
    {
        [JsonProperty("i")]
        public long I { get; set; }

        [JsonProperty("offset")]
        public long Offset { get; set; }

        [JsonProperty("r")]
        public long R { get; set; }

        [JsonProperty("ratio")]
        public double Ratio { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("x")]
        public long X { get; set; }
    }

    public partial class BgTargets
    {
        [JsonProperty("first")]
        public long First { get; set; }

        [JsonProperty("sensitivities")]
        public List<Sensitivities> Sensitivities { get; set; }

        [JsonProperty("targets")]
        public List<Targets> Targets { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }

        [JsonProperty("user_preferred_units")]
        public string UserPreferredUnits { get; set; }
    }

    public partial class Targets
    {
        [JsonProperty("high")]
        public long High { get; set; }

        [JsonProperty("i")]
        public long I { get; set; }

        [JsonProperty("low")]
        public long Low { get; set; }

        [JsonProperty("max_bg")]
        public long? MaxBg { get; set; }

        [JsonProperty("min_bg")]
        public long? MinBg { get; set; }

        [JsonProperty("offset")]
        public long Offset { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("x")]
        public long X { get; set; }
    }

    public partial class Sensitivities
    {
        [JsonProperty("endOffset")]
        public long EndOffset { get; set; }

        [JsonProperty("i")]
        public long I { get; set; }

        [JsonProperty("offset")]
        public long Offset { get; set; }

        [JsonProperty("sensitivity")]
        public double Sensitivity { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("x")]
        public long X { get; set; }
    }

    public partial class Basalprofile
    {
        [JsonProperty("i")]
        public long I { get; set; }

        [JsonProperty("minutes")]
        public long Minutes { get; set; }

        [JsonProperty("rate")]
        public double Rate { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }
    }

    public partial class Profile
    {
        public static Profile FromJson(string json) => JsonConvert.DeserializeObject<Profile>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Profile self) => JsonConvert.SerializeObject(self, Converter.Settings);
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
