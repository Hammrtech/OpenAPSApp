using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using SkiaSharp;

namespace OpenAPSApp.Helpers
{
    public class Utility
    {
        public Utility()
        {
        }

        public async static Task<string> GetJsonFromURL(string URL)
        {
            HttpClient client = new HttpClient();
            var uri = new Uri(string.Format(URL, string.Empty));
            string content = "";

            var response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                content = await response.Content.ReadAsStringAsync();

            }

            return content;
        }

        public static List<Microcharts.Entry> ConvertGlucoseListToEntry(List<Glucose> gList)
        {
            List<Microcharts.Entry> entList = new List<Microcharts.Entry>();

            gList = gList.Where(g => Convert.ToDateTime(g.DateString) >= DateTime.Now.AddHours(-3)).ToList();

            foreach(Glucose g in gList)
            {
                SKColor color = new SKColor();
                if(g.BloodGlucose < 180 && g.BloodGlucose > 70)
                {
                    color = SKColor.Parse("#7CC76C");
                }
                else if (g.BloodGlucose >= 180)
                {
                    color = SKColor.Parse("#FCCF0A");

                }
                else if (g.BloodGlucose <=70)
                {
                    
                    color = SKColor.Parse("#F9706B");
                }

                entList.Add(new Microcharts.Entry(g.BloodGlucose)
                {
                    Label = g.DateString,
                    ValueLabel = g.BloodGlucose.ToString(),
                    Color = color

                }
                );
            }

            return entList;
        }

    }
}
