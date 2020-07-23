using Async_Await_Demo.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Async_Await_Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Progress<ProgressReportModel> progress = new Progress<ProgressReportModel>();
        CancellationTokenSource cts = new CancellationTokenSource();

        public MainWindow()
        {
            InitializeComponent();

            // Initial event handler of DemoMethods class
            DemoMethods.ResultOfDownloadEventHandler += PrintReuslt;


            progress.ProgressChanged += ReportProgress;
        }

        private void executeSync_Click(object sender, RoutedEventArgs e)
        {
            var watch = Stopwatch.StartNew();

            //DemoMethods.RunDownloadSync();
            DemoMethods.RunDownloadParallelSync();

            watch.Stop();

            var elapseMs = watch.ElapsedMilliseconds;

            resultWindow.Text += $"Total execution time: { elapseMs }";
        }


        private async void executeASync_Click(object sender, RoutedEventArgs e)
        {

            var watch = Stopwatch.StartNew();

            try
            {
                await DemoMethods.RunDownloadASync(progress, cts.Token);
            }
            // Catch the cancel exception of RunDownloadAsync
            catch (OperationCanceledException)
            {

                resultWindow.Text += $"The async download was cancelled {Environment.NewLine}";
            }

            watch.Stop();

            var elapseMs = watch.ElapsedMilliseconds;

            resultWindow.Text += $"Total execution time: { elapseMs }";
        }

        private void ReportProgress(object sender, ProgressReportModel e)
        {
            dashBoardProgress.Value = e.PecentageComplete;
            PrintReuslt(sender, e.SitesDownaloed);
        }

        private async void parallelAsync_Click(object sender, RoutedEventArgs e)
        {
            var watch = Stopwatch.StartNew();

            //await RunDownloadASync();
            await DemoMethods.RunDownloadParallelASyncV2(progress);

            watch.Stop();

            var elapseMs = watch.ElapsedMilliseconds;

            resultWindow.Text += $"Total execution time: { elapseMs }";
        }

        private void cancelOpertaion_Click(object sender, RoutedEventArgs e)
        {
            cts.Cancel();
        }

        private void PrintReuslt(object sender, List<WebSiteDataModel> results)
        {
            resultWindow.Text = "";
            foreach (var item in results)
            {
                // add data of current website to text box
                ReportWebsiteInfo(item);
            }
        }

        private void ReportWebsiteInfo(WebSiteDataModel result)
        {
            resultWindow.Text += $"{result.WebsiteUrl} downloaded: {result.WebsiteData.Length} characters long.{Environment.NewLine}";
        }
    }
}
