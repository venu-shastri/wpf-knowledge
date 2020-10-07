using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfCodeOnly
{
    public class MainWindow:Window
    {
        Button button;
        TextBox textBox;
        StackPanel _layoutControl;
        public MainWindow()
        {
            this.Title = "MainWindow";

            this.button = new Button();
            this.button.Width = 100d;
            this.button.Height = 50d;
            this.button.Content = "Click Here";
            this.button.Click += Button_Click;

            this.textBox = new TextBox();
            this.textBox.Width = 100d;
            this.textBox.Height = 30d;

            this._layoutControl = new StackPanel();
            this._layoutControl.Orientation = Orientation.Horizontal;
           this. _layoutControl.Children.Add(this.button);
            this._layoutControl.Children.Add(this.textBox);

            this.Content = this._layoutControl;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(this.textBox.Text);
        }
    }
}
