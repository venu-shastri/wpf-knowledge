using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCodeOnly
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            System.Windows.Application _wpfApp = new System.Windows.Application();
            MainWindow _window = new MainWindow();
            _wpfApp.Run(_window);
        }
    }
}
