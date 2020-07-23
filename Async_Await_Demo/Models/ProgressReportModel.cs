using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_Await_Demo.Models
{
    public class ProgressReportModel
    {
        public int PecentageComplete { get; set; } = 0;
        public List<WebSiteDataModel> SitesDownaloed { get; set; } = new List<WebSiteDataModel>();

    }
}
