using System;

namespace A21_Ex01_Amit_312346901_Obaide_318970290
{
    public class WeatherURL : IURL
    {
        private readonly string r_WeatherTemplateUrl;

        public WeatherURL()
        {
            r_WeatherTemplateUrl = "https://www.google.com/search?q={0}+weather";
        }

        public Uri GetURL(string i_Location)
        {
            return new Uri(string.Format(r_WeatherTemplateUrl, i_Location));
        }
    }
}
