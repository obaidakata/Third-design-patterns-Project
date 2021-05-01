using System;

namespace FaceLikers
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
