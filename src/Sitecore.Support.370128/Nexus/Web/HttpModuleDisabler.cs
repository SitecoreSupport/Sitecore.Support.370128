namespace Sitecore.Support.Nexus.Web
{
    using Sitecore.Support.Utils;
    using System;
    using System.Web;

    public class HttpModuleDisabler : IHttpModule
    {
        public void Dispose()
        {
        }

        private void HttpApplication_BeginRequest(object sender, EventArgs e)
        {
            if (CheckIgnoreURL.Check(HttpContext.Current.Request.Url.AbsolutePath))
            {
                HttpContext.Current.Items["HttpRequestAborted"] = "1";
            }
        }

        public void Init(HttpApplication context)
        {
            context.BeginRequest += new EventHandler(this.HttpApplication_BeginRequest);
        }
    }
}