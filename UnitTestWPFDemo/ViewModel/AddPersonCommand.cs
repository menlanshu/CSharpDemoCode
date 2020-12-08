using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;
using UnitTestDemoLibrary.Models;

namespace UnitTestWPFDemo.ViewModel
{
    class AddPersonCommand : ICommand
    {
        private MainWindowViewModel _viewModel;

        public AddPersonCommand(MainWindowViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var newPerson = new PersonModel
            {
                FirstName = _viewModel.FirstName,
                LastName = _viewModel.LastName
            };
            _viewModel.MyDataAccess.AddNewPerson(newPerson);
            _viewModel.People.Add(newPerson);
            _viewModel.SelectedPerson = newPerson;
            MessageBox.Show("Add Success");
        }
    }
}
