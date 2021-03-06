﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace MVVMDemo.Views
{
    /// <summary>
    /// Interaction logic for Calculator.xaml
    /// </summary>
    public partial class Calculator : UserControl
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
          ViewModels.CalculatorViewModel _viewModel=  (this.DataContext as ViewModels.CalculatorViewModel);
            if (_viewModel.AddCommand.CanExecute(null))
            {
                _viewModel.AddCommand.Execute(null);

            }

        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            ViewModels.CalculatorViewModel _viewModel = (this.DataContext as ViewModels.CalculatorViewModel);
            if (_viewModel.ClearCommand.CanExecute(null))
            {
                _viewModel.ClearCommand.Execute(null);

            }
        }
    }
}
