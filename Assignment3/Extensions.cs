using System;

namespace BDSA2020.Assignment02
{
    public static class Extensions
    {
        public static bool isSecure(this Uri uri){
            return uri.Scheme == Uri.UriSchemeHttps;
        }
    }
}
