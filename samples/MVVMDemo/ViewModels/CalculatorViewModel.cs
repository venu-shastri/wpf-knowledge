using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMDemo.ViewModels
{
    public class CalculatorViewModel:INotifyPropertyChanged
    {
        #region Fields
        int operandOne, operandTwo,result;
        #endregion

        #region Initializers
        public CalculatorViewModel()
        {
            this.AddCommand = new Commands.AddCommandClass(this);
        }
        #endregion

        #region Properties
        public int OperandOne
        {
            get { return this.operandOne; }
            set {
                if (value != operandOne)
                {
                    this.operandOne = value;
                    OnPropertyChanged("OperandOne");
                }
            }
        }
        public int OperandTwo
        {
            get { return this.operandTwo; }
            set {
                if (value != operandTwo)
                {
                    this.operandTwo = value;
                    OnPropertyChanged("OperandTwo");
                }
            }
        }
        public int Result
        {
            get { return this.result; }
            set
            {
                if (value != result)
                {
                    this.result = value;
                    OnPropertyChanged("Result");
                }
            }
        }


        #endregion

        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Logic
        public void Add()
        {
            Result = operandOne + operandTwo;
        }
        public void Clear()
        {
            this.OperandOne = 0;
            this.OperandTwo = 0;
            this.Result = 0;
        }
        private void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

        #region Commands
        public  ICommand AddCommand
        {
            get;set;
        }
        #endregion
    }
}
