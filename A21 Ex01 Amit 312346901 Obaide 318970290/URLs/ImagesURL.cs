using System;

namespace A21_Ex01_Amit_312346901_Obaide_318970290
{
    public class ImagesURL : IURL
    {
        private readonly string r_ImagesTemplateUrl;

        public ImagesURL()
        {
            r_ImagesTemplateUrl = "https://www.google.com/search?q={0}&tbm=isch&q=findSomeImage";
        }

        public Uri GetURL(string i_Location)
        {
            return new Uri(string.Format(r_ImagesTemplateUrl, i_Location));
        }
    }
}
