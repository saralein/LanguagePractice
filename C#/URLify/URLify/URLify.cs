using System;

namespace URLifyKata
{
    public class URLify
    {
        public string ConvertStringToURL(string str, int trueLen)
        {
            var strArray = str.Substring(0, trueLen).Split(' ');
            return string.Join("%20", strArray);
        }
    }
}
