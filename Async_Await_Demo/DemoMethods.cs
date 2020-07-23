using Async_Await_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async_Await_Demo
{
    public static class DemoMethods
    {
        // After download, we should notify user that we already downloaded finished~
        // Better to create a new class to save all data that you want to pass
        public static EventHandler<List<WebSiteDataModel>> ResultOfDownloadEventHandler;

        // Download site async
        // Don't use void as a return type of async => exception will not be catched if use void in normal async method
        // But there is an exception, for event handler method. Void is accepted
        // if you want to return nothing use Task
        // If you want to return string use Task<string>
        public static async Task RunDownloadASync(IProgress<ProgressReportModel> progress,
            CancellationToken cancellationToken)
        {
            List<string> websites = PreData();
            List<WebSiteDataModel> results = new List<WebSiteDataModel>();

            ProgressReportModel report = new ProgressReportModel();

            foreach (string site in websites)
            {
                // download data from the website

                // Put function into a task bubble
                // We await because we need this result for reportwebsiteinfo
                WebSiteDataModel result = await Task.Run(() => DownloadWebSite(site));
                results.Add(result);

                // assign value to report instance
                report.SitesDownaloed = results;
                report.PecentageComplete = (report.SitesDownaloed.Count * 100) / websites.Count;

                progress.Report(report);

                // Cancel logic put to here
                cancellationToken.ThrowIfCancellationRequested();
            }

            ResultOfDownloadEventHandler(null, results);
        }

        public static void RunDownloadParallelSync()
        {
            List<string> websites = PreData();
            List<WebSiteDataModel> results = new List<WebSiteDataModel>();

            // Use parallel to download all websites at the same time
            // but parallel still will lock down the instance untill all downloads finished
            // So you can't move windows untill everything is done
            Parallel.ForEach<string>(
                websites,
                (site) =>
                {
                    // download data from the website
                    WebSiteDataModel result = DownloadWebSite(site);
                    results.Add(result);
                });

            ResultOfDownloadEventHandler(null, results.ToList());
        }

        public static async Task RunDownloadParallelASyncV2(IProgress<ProgressReportModel> progress)
        {
            List<string> websites = PreData();
            List<WebSiteDataModel> results = new List<WebSiteDataModel>();

            ProgressReportModel report = new ProgressReportModel();

            await Task.Run(() =>
            {
                Parallel.ForEach<string>(
                    websites,
                    (site) =>
                    {
                        // download data from the website
                        WebSiteDataModel result = DownloadWebSite(site);
                        results.Add(result);

                        // assign value to report instance
                        report.SitesDownaloed = results;
                        report.PecentageComplete = (report.SitesDownaloed.Count * 100) / websites.Count;

                        progress.Report(report);
                    });


            });

            ResultOfDownloadEventHandler(null, results.ToList());
        }

        public static async Task RunDownloadParallelASync()
        {
            List<string> websites = PreData();
            List<Task<WebSiteDataModel>> tasks = new List<Task<WebSiteDataModel>>();

            foreach (string site in websites)
            {
                // download data from the website

                // Put function into a task list bubble
                tasks.Add(DownloadWebSiteAsync(site));

            }

            // We await because we need this result for reportwebsiteinfo
            var results = await Task.WhenAll(tasks);

            ResultOfDownloadEventHandler(null, results.ToList());
        }


        public static void RunDownloadSync()
        {
            List<string> websites = PreData();
            List<WebSiteDataModel> results = new List<WebSiteDataModel>();

            foreach (string site in websites)
            {
                // download data from the website
                WebSiteDataModel result = DownloadWebSite(site);
                results.Add(result);
            }

            ResultOfDownloadEventHandler(null, results.ToList());
        }


        private static WebSiteDataModel DownloadWebSite(string websiteURL)
        {
            // Initial output web site data
            // Initial web client for get url data
            WebSiteDataModel output = new WebSiteDataModel();
            WebClient client = new WebClient();

            // assign web url
            output.WebsiteUrl = websiteURL;
            // download data from website
            output.WebsiteData = client.DownloadString(websiteURL);

            return output;

        }



        private static async Task<WebSiteDataModel> DownloadWebSiteAsync(string websiteURL)
        {
            // Initial output web site data
            // Initial web client for get url data
            WebSiteDataModel output = new WebSiteDataModel();
            WebClient client = new WebClient();

            // assign web url
            output.WebsiteUrl = websiteURL;
            // download data from website
            output.WebsiteData = await client.DownloadStringTaskAsync(websiteURL);

            return output;
        }

        private static List<string> PreData()
        {
            List<string> output = new List<string>();

            output.Add("https://www.baidu.com");
            output.Add("https://www.baidu.com");
            output.Add("https://www.baidu.com");
            output.Add("https://www.baidu.com");
            output.Add("https://www.microsoft.com");
            output.Add("https://www.stackoverflow.com");

            return output;
        }
    }
}
