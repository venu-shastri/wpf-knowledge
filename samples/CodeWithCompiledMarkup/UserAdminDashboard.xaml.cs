using System;
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
using System.Windows.Media.Media3D;
using System.Windows.Shapes;

namespace CodeWithCompiledMarkup
{
    /// <summary>
    /// Interaction logic for UserAdminDashboard.xaml
    /// </summary>
    public partial class UserAdminDashboard : Window
    {
        Models.UserDataModel _userDataModel = new Models.UserDataModel();
        public UserAdminDashboard()
        {
            InitializeComponent();
            this.DataContext = _userDataModel;
        }

        //public string UserName
        //{
        //    get { return this._userDataModel.UserName; }
        //    set { this._userDataModel.UserName= value; }
        //}
        //public string Password
        //{
        //    get { return this._userDataModel.Password; }
        //    set { this._userDataModel.Password = value; }
        //}
        //public string Email
        //{
        //    get { return this._userDataModel.Email; }
        //    set { this._userDataModel.Email = value; }
        //}

        private void RegisterButton_Click(object sender, RoutedEventArgs e)

        { 
            string  userInfo=$"{this._userDataModel.UserName} , {this._userDataModel.Password},{this._userDataModel.Email}";
            MessageBox.Show(userInfo);




        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(this._userDataModel.UserName + " before edit");
            this._userDataModel.UserName = "XYZ";
            MessageBox.Show(this._userDataModel.UserName);
        }
    }
}
