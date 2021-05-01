using System;

namespace FaceLikers
{
    public class RestaurantsURL : IURL
    {
        private readonly string r_RestaurantsTemplateUrl;

        public RestaurantsURL()
        {
            r_RestaurantsTemplateUrl = "https://www.yelp.com/search?find_desc=Restaurants&find_loc={0}%2C+CA&ns=1";
        }

        public Uri GetURL(string i_Location)
        {
            return new Uri(string.Format(r_RestaurantsTemplateUrl, i_Location));
        }
    }
}
