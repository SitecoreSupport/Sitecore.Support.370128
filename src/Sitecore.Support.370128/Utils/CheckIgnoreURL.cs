namespace Sitecore.Support.Utils
{
    using Sitecore.Configuration;
    using System;

    public static class CheckIgnoreURL
    {
        public static bool Check(string url)
        {
            string setting = Settings.GetSetting("AbsoluteIgnoreUrlPrefixes");
            if (!string.IsNullOrEmpty(setting))
            {
                 string[] strArray = setting.Split(new char[] { '|' });
                if (strArray.Length > 0)
                {
                    for (int i = 0; i < strArray.Length; i++)
                    {
                        if (url.StartsWith(strArray[i], StringComparison.OrdinalIgnoreCase))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}