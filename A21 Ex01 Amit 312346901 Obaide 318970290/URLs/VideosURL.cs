using System;

namespace FaceLikers
{
    public class VideosURL : IURL
    {
        private readonly string r_VideosTemplateUrl;

        public VideosURL()
        {
            r_VideosTemplateUrl = "https://www.google.com/search?q={0}&tbm=vid";
        }

        public Uri GetURL(string i_Location)
        {
            return new Uri(string.Format(r_VideosTemplateUrl, i_Location));
        }
    }
}
