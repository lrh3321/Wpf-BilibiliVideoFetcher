using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilibiliVideoFetcher.Helper
{
    public class UrlHelper
    {
        const string THUNDER_PROTOCAL = "thunder://";
        public static string FixUrl(string url)
        {
            if (!(url.StartsWith("http://") || url.StartsWith("https://")))
            {
                return "http://" + url;
            }
            else
            {
                return url;
            }
        }

        public static string ConvertToThunder(string url)
        {
            var str = $"AA{url.Trim()}ZZ";

            return $"{THUNDER_PROTOCAL}{Convert.ToBase64String(Encoding.UTF8.GetBytes(str))}";
        }
    }
}
