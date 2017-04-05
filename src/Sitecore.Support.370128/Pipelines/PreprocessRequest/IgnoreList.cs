namespace Sitecore.Support.Pipelines.PreprocessRequest
{
    using Sitecore.Pipelines.PreprocessRequest;
    using Sitecore.Support.Utils;
    using System;
    using System.Web;

    public class IgnoreList : PreprocessRequestProcessor
    {
        public override void Process(PreprocessRequestArgs args)
        {
            if (CheckIgnoreURL.Check(HttpContext.Current.Request.Url.AbsolutePath))
            {
                args.AbortPipeline();
            }
        }
    }
}