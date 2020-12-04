using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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

namespace AsyncSelfDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CancellationTokenSource cts = new CancellationTokenSource();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnNormalSync_Click(object sender, RoutedEventArgs e)
        {
            Stopwatch newWatch = new Stopwatch();
            this.txWindow.Clear();

            newWatch.Start();

            Progress<ProgressDataModel> progress = new Progress<ProgressDataModel>();
            progress.ProgressChanged += Progress_ProgressChanged;

            var websiteData = DownloadWebsiteDemo.RunNormalSyncMethod(progress);

            newWatch.Stop();

            var costTime = newWatch.ElapsedMilliseconds;

            this.txWindow.Text += $"Total Cost time is {costTime}";

        }

        private void Progress_ProgressChanged(object sender, ProgressDataModel e)
        {
            this.pbProcessBar.Value = e.PercentageDownloaded;
            PrintResult(e.WebSiteDataDownloaded);
        }

        private async void btnNormalAsync_Click(object sender, RoutedEventArgs e)
        {
            Stopwatch newWatch = new Stopwatch();
            this.txWindow.Clear();

            newWatch.Start();

            Progress<ProgressDataModel> progress = new Progress<ProgressDataModel>();
            progress.ProgressChanged += Progress_ProgressChanged;

            try
            {
                var websiteData = await DownloadWebsiteDemo.RunNormalAsyncMethod(progress, cts.Token);

            }
            catch (OperationCanceledException)
            {
                this.txWindow.Text += $"Cancel Download{Environment.NewLine}";
            }
            newWatch.Stop();

            var costTime = newWatch.ElapsedMilliseconds;

            this.txWindow.Text += $"Total Cost time is {costTime}";
        }

        private async void btnParallelAsync_Click(object sender, RoutedEventArgs e)
        {
            Stopwatch newWatch = new Stopwatch();
            this.txWindow.Clear();

            newWatch.Start();

            Progress<ProgressDataModel> progress = new Progress<ProgressDataModel>();
            progress.ProgressChanged += Progress_ProgressChanged;

            var websiteData = await DownloadWebsiteDemo.RunParallellAsyncMethod(progress);

            newWatch.Stop();

            var costTime = newWatch.ElapsedMilliseconds;

            this.txWindow.Text += $"Total Cost time is {costTime}";
        }

        private void btnCancelButton_Click(object sender, RoutedEventArgs e)
        {
            cts.Cancel();
        }

        public void PrintResult(List<WebSiteDataModel> webSiteDataModels)
        {
            this.txWindow.Text = "";
            foreach(var data in webSiteDataModels)
            {
                this.txWindow.Text += $"Download data from {data.WebURL}, length is {data.WebDataContent.Length}{Environment.NewLine}";
            }
        }
    }
}
