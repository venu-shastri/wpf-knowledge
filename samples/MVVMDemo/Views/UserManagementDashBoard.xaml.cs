using MVVMDemo.ViewModels;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MVVMDemo.Views
{
    /// <summary>
    /// Interaction logic for UserManagementDashBoard.xaml
    /// </summary>
    public partial class UserManagementDashBoard : UserControl
    {
        UserAdminDashBoardViewModel _viewModel = new UserAdminDashBoardViewModel();
        public UserManagementDashBoard()
        {
            InitializeComponent();
            this.DataContext = _viewModel;
        }
    }
}
