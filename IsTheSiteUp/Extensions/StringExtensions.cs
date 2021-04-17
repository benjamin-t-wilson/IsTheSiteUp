using System;

namespace IsTheSiteUp.Extensions
{
    public static class StringExtensions
    {
        public static bool IsInvalidUrl(this string url)
        {
            return string.IsNullOrWhiteSpace(url) || !Uri.TryCreate(url, UriKind.Absolute, out var _);
        }
    }
}