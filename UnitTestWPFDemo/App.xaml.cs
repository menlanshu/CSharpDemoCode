using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using UnitTestWPFDemo.ViewModel;

namespace UnitTestWPFDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            // Remove StartupURL from app.xaml
            // Define MainWindowViewModel
            // Assign DataContext

            // MainWindowVIewModel implement
            // public event PropertyChangedEventHandler PropertyChanged;
            //protected void NotifyPropertyChanged(String info)
            //{
            //    if (PropertyChanged != null)
            //    {
            //        PropertyChanged(this, new PropertyChangedEventArgs(info));
            //    }
            //}

            // Each property invoke NotifyPropertyChanged after value changed
            //public List<IPersonModel> People
            //{
            //    get { return _people; }
            //    set
            //    {
            //        _people = value;
            //        NotifyPropertyChanged(nameof(People));
            //    }
            //}
            // Add config to xaml file
            //  < ComboBox Grid.Row = "1" Grid.Column = "1"
            // Margin = "5"
            //ItemsSource = "{Binding People}"
            //SelectedItem = "{Binding SelectedPerson}"
            //DisplayMemberPath = "FullName" />

            // Define Command
            // Inherit from ICommand
            // Binding command to button
            // Command="{Binding PersonAddCommand}"



            // Create the startup window
            MainWindow wnd = new MainWindow();
			// Do stuff here, e.g. to the window
			wnd.Title = "Unit Test Demo WPF";
            wnd.DataContext = new MainWindowViewModel();
			// Show the window
			wnd.Show();
        }
	}
}
