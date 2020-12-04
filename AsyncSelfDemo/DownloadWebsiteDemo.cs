using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncSelfDemo
{
    public class DownloadWebsiteDemo
    {
        public static List<string> PreWebSiteList()
        {
            List<string> output = new List<string>();

            output.Add("https://www.baidu.com");
            output.Add("https://www.sohu.com/");
            output.Add("https://www.github.com");
            output.Add("https://www.bing.com/");


            return output;
        }
        public static List<WebSiteDataModel> RunNormalSyncMethod(IProgress<ProgressDataModel> progress)
        {
            var downloadSites = PreWebSiteList();
            List<WebSiteDataModel> output = new List<WebSiteDataModel>();
            ProgressDataModel progressData = new ProgressDataModel();
            progressData.WebSiteDataDownloaded = new List<WebSiteDataModel>();

            foreach(var site in downloadSites)
            {
                var data = DownloadSiteDataSync(site);
                output.Add(data);

                // assign data to progressdata
                progressData.WebSiteDataDownloaded.Add(data);
                progressData.PercentageDownloaded = (progressData.WebSiteDataDownloaded.Count() * 100) / downloadSites.Count();
                progress.Report(progressData);
            }

            return output;
        }
        public async static Task<List<WebSiteDataModel>> RunNormalAsyncMethod(IProgress<ProgressDataModel> progress, CancellationToken cancellationToken)
        {
            var downloadSites = PreWebSiteList();
            List<WebSiteDataModel> output = new List<WebSiteDataModel>();
            ProgressDataModel progressData = new ProgressDataModel();
            progressData.WebSiteDataDownloaded = new List<WebSiteDataModel>();

            foreach (var site in downloadSites)
            {
                var data = await DownloadSiteDataAsync(site);
                output.Add(data);

                // assign data to progressdata
                progressData.WebSiteDataDownloaded.Add(data);
                progressData.PercentageDownloaded = (progressData.WebSiteDataDownloaded.Count() * 100) / downloadSites.Count();
                progress.Report(progressData);

                cancellationToken.ThrowIfCancellationRequested();
            }

            return output;
        }

        public async static Task<List<WebSiteDataModel>> RunParallellAsyncMethod(IProgress<ProgressDataModel> progress)
        {
            var downloadSites = PreWebSiteList();
            //List<Task<WebSiteDataModel>> taskList = new List<Task<WebSiteDataModel>>();
            List<WebSiteDataModel> output = new List<WebSiteDataModel>();
            List<Task> taskList = new List<Task>();
            ProgressDataModel progressData = new ProgressDataModel();
            progressData.WebSiteDataDownloaded = new List<WebSiteDataModel>();

            foreach (var site in downloadSites)
            {
                //taskList.Add(DownloadSiteDataAsync(site));
                //another way just use sync method to do async action
                taskList.Add(
                    Task.Run(
                        () =>
                        {
                            var data = DownloadSiteDataSync(site);
                            output.Add(data);

                            // assign data to progressdata
                            progressData.WebSiteDataDownloaded.Add(data);
                            progressData.PercentageDownloaded = (progressData.WebSiteDataDownloaded.Count() * 100) / downloadSites.Count();
                            progress.Report(progressData);
                        }
                        ));
            }

            //var output = new List<WebSiteDataModel>(await Task.WhenAll(taskList));
            await Task.WhenAll(taskList);

            return output;
        }
        public static List<WebSiteDataModel> RunParallellSyncMethod()
        {
            var downloadSites = PreWebSiteList();
            List<WebSiteDataModel> output = new List<WebSiteDataModel>();

            Parallel.ForEach(downloadSites,
                site =>
                {
                    var data = DownloadSiteDataSync(site);
                    output.Add(data);
                });

            return output;
        }

        public static List<WebSiteDataModel> RunAnotherParallellASyncMethod()
        {
            var downloadSites = PreWebSiteList();
            List<WebSiteDataModel> output = new List<WebSiteDataModel>();

            Task.Run(() => Parallel.ForEach(downloadSites,
                site =>
                {
                    var data = DownloadSiteDataSync(site);
                    output.Add(data);
                })
            );

            return output;
        }

        public async static Task<WebSiteDataModel> DownloadSiteDataAsync(string site)
        {
            WebClient webClient = new WebClient();
            WebSiteDataModel output = new WebSiteDataModel();

            output.WebURL = site;
            output.WebDataContent = await webClient.DownloadStringTaskAsync(site);

            return output;
        }


        public static WebSiteDataModel DownloadSiteDataSync(string site)
        {
            WebClient webClient = new WebClient();
            WebSiteDataModel output = new WebSiteDataModel();

            output.WebURL = site;
            output.WebDataContent = webClient.DownloadString(site);

            return output;
        }
    }
}
