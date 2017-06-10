using System;
namespace OpenAPSApp.Models
{
    public class Status
    {
        public double CurrentBG
        {
            get;
            set;
        }
        public string CurrentDelta
        {
            get;
            set;
        }
        public string CurrentTrendArrow
        {
            get;
            set;
        }
        public string CurrentBGDisplay
        {
            get{
                return $"BG: {CurrentBG} {CurrentDelta} {CurrentTrendArrow}";
                
            }
            set{
                
            }
        }
        public int MinutesSinceLastBG
        {
            get;
            set;
        }
        // TODO: Calculate this in the app instead, based on a timestamp received from the rig
        public string MinutesSinceLastBGDisplay
		{
			get
			{
				return $"Last BG received {MinutesSinceLastBG}m ago";

			}
			set
			{

			}
		}
        public double CurrentIOB
        {
            get;
            set;
        }
        public double CurrentCOB
        {
            get;
            set;
        }
		public string CurrentIOBCOBDisplay
		{
			get
			{
                return $"IOB: {CurrentIOB}, COB: {CurrentCOB}";

			}
			set
			{

			}
		}
		public double EventualBG
        {
            get;
            set;
        }
		public string EventualBGDisplay
		{
			get
			{
                return $"Eventual BG: {EventualBG}";

			}
			set
			{

			}
		}
		public string LoopStatus
        {
            get;
            set;
        }
        public string CurrentTempBasal
        {
            get;
            set;
        }
		public string CurrentTempBasalDisplay
		{
			get
			{
				return $"Current Temp Basal: {CurrentTempBasal}";

			}
			set
			{

			}
		}
		public string OpenAPSReason
        {
            get;
            set;
        }
		public string OpenAPSReasonDisplay
		{
			get
			{
				return $"OpenAPS Reason: {OpenAPSReason}";

			}
			set
			{

			}
		}
    }
}
