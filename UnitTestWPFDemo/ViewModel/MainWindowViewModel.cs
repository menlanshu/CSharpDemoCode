using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using UnitTestDemoLibrary;
using UnitTestDemoLibrary.Models;

namespace UnitTestWPFDemo.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        DataAccess _dataAccess;
        Calculator _calculator;

        public Calculator MyCalculator
        {
            get
            {
                return _calculator;
            }
        }

        public DataAccess MyDataAccess
        {
            get
            {
                return _dataAccess;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        private IPersonModel _selectedPerson;

        public IPersonModel SelectedPerson
        {
            get { return _selectedPerson; }
            set
            {
                _selectedPerson = value;
                FirstName = _selectedPerson.FirstName;
                LastName = _selectedPerson.LastName;
                NotifyPropertyChanged(nameof(SelectedPerson));
            }
        }


        private List<IPersonModel> _people;

        public List<IPersonModel> People
        {
            get { return _people; }
            set
            {
                _people = value;
                NotifyPropertyChanged(nameof(People));
            }
        }

        private double _calculateResult;

        public double CalculateResult
        {
            get { return _calculateResult; }
            set
            {
                _calculateResult = value;
                NotifyPropertyChanged(nameof(CalculateResult));
            }
        }

        private double _valueX;

        public double ValueX
        {
            get { return _valueX; }
            set { _valueX = value;
                NotifyPropertyChanged(nameof(ValueX));
            }
        }

        private double _valueY;

        public double ValueY
        {
            get { return _valueY; }
            set { _valueY = value;
                NotifyPropertyChanged(nameof(ValueY));
            }
        }

        private string _firstname;

        public string FirstName
        {
            get { return _firstname; }
            set { _firstname = value;
                NotifyPropertyChanged(nameof(FirstName));
            }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; 
                NotifyPropertyChanged(nameof(LastName));
            }
        }




        public ICommand AddCommand { get; private set; }
        public ICommand SubstractCommand { get; private set; }
        public ICommand MultiplyCommand { get; private set; }
        public ICommand DivideCommand { get; private set; }
        public ICommand PersonAddCommand { get; private set; }



        public MainWindowViewModel()
        {
            _dataAccess = new DataAccess();
            _calculator = new Calculator();

            AddCommand = new CalculateCommand(this, CalcType.Add);
            SubstractCommand = new CalculateCommand(this, CalcType.Substract);
            MultiplyCommand = new CalculateCommand(this, CalcType.Multiply);
            DivideCommand = new CalculateCommand(this, CalcType.Divide);
            PersonAddCommand = new AddPersonCommand(this);

            People = _dataAccess.GetAllPeople();
        }
    }
}
