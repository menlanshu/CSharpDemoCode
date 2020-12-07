using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace UnitTestWPFDemo.ViewModel
{
    public class CalculateCommand : ICommand
    {
        private MainWindowViewModel _viewModel;
        private CalcType _calcType;
        public CalculateCommand(MainWindowViewModel viewModel, CalcType calcType)
        {
            _viewModel = viewModel;
            _calcType = calcType;
        }

        // see later
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _viewModel.CalculateResult = _calcType switch
            {
                CalcType.Add => _viewModel.MyCalculator.Add(_viewModel.ValueX, _viewModel.ValueY),
                CalcType.Substract => _viewModel.MyCalculator.Substract(_viewModel.ValueX, _viewModel.ValueY),
                CalcType.Multiply => _viewModel.MyCalculator.Multiply(_viewModel.ValueX, _viewModel.ValueY),
                CalcType.Divide => _viewModel.MyCalculator.Divide(_viewModel.ValueX, _viewModel.ValueY),
                _ => throw new InvalidOperationException("No valid calculation type")
            };
        }
    }

    public enum CalcType
    {
        Add,
        Substract,
        Multiply,
        Divide
    }
}
