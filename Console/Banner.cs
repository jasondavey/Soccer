using System;
using System.Linq;

namespace Console
{
    public static class Banner
    {
        public static string HorizontalTitleBorder(string title, string bannerChar = "-")
        {
            var borderTop = $"{Environment.NewLine}{string.Concat(Enumerable.Repeat(bannerChar, title.Length))}{Environment.NewLine}";
            var borderBottom = borderTop;

            return String.Concat(borderTop, title, borderBottom);
        }
    }
}
