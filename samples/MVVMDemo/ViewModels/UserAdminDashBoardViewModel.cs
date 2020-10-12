using MVVMDemo.Commands;
using MVVMDemo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace MVVMDemo.ViewModels
{
    public class UserAdminDashBoardViewModel:BaseViewModel
    {
        Models.UserDataModel _userDataModel = new Models.UserDataModel();
        ObservableCollection<Models.UserDataModel> _userDataModelList = 
            new ObservableCollection<Models.UserDataModel>();

        public UserAdminDashBoardViewModel() {

            this.AddNewUserCommand = new DelegateCommandClass(this.AddNewUserCommandWrapper,
                this.CommandCanExecuteWrapper);
        }
           
        public  string Name
        {
            get { return this._userDataModel.Name; }
            set
            {

                if (value != this._userDataModel.Name)
                {
                    this._userDataModel.Name = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Password
        {
            get { return this._userDataModel.Password; }
            set
            {

                if (value != this._userDataModel.Password)
                {
                    this._userDataModel.Password = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Email
        {
            get { return this._userDataModel.Email; }
            set
            {

                if (value != this._userDataModel.Email)
                {
                    this._userDataModel.Email = value;
                    OnPropertyChanged();
                }
            }
        }

        public ObservableCollection<UserDataModel> UserDataModelList
        {
            get { return this._userDataModelList; }
            set { this._userDataModelList = value; }
        }

        public void AddNewUser()
        {
            this.UserDataModelList.Add(this._userDataModel.Clone());
        }

        public ICommand AddNewUserCommand { get; set; }

        void AddNewUserCommandWrapper(object parameter)
        {
            this.AddNewUser();
        }
        bool CommandCanExecuteWrapper(object parameter)
        {
            return true;
        }
    }
}
