using System.Collections.Generic;

namespace AsyncSelfDemo
{
    public class ProgressDataModel
    {
        public int PercentageDownloaded { get; set; }
        public List<WebSiteDataModel> WebSiteDataDownloaded { get; set; }
    }
}