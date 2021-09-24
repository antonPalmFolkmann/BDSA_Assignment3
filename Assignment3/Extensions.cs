using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace Assignment3
{
    public static class Extensions
    {
        public static bool isSecure(this Uri uri)
        {
            return uri.Scheme == Uri.UriSchemeHttps;
        }

        public static int wordCount(this string text)
        {
            return Regex.Split(text, @"\P{L}+").Where(s => s.Trim() != "").Count();

        }
    }
}
