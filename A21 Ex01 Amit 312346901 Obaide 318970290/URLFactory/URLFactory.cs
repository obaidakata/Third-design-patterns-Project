using System;

namespace A21_Ex01_Amit_312346901_Obaide_318970290
{
    public static class URLFactory
    {
        public static IURL CreateURL(eURLType i_Type)
        {
            IURL url;
            switch (i_Type)
            {
                case eURLType.Images:
                    url = new ImagesURL();
                    break;
                case eURLType.Videos:
                    url = new VideosURL();
                    break;
                case eURLType.Weather:
                    url = new WeatherURL();
                    break;
                case eURLType.Restaurants:
                    url = new RestaurantsURL();
                    break;
                default:
                    url = new ImagesURL();
                    break;
            }

            return url;
        }

        public static string[] GetSupportedURLTypes()
        {
            return Enum.GetNames(typeof(eURLType));
        }
    }
}
