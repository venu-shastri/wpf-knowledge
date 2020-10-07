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
using System.Windows.Shapes;

namespace CodeWithCompiledMarkup
{
    /// <summary>
    /// Interaction logic for StylesDemo.xaml
    /// </summary>
    public partial class StylesDemo : Window
    {
        public StylesDemo()
        {
            InitializeComponent();

            Style _buttonStyle = new Style();

            Setter _heightSetter = new Setter();
            _heightSetter.Property = Button.HeightProperty; //Dependency Property
            _heightSetter.Value = 30d;

            Setter _widthSetter = new Setter(Button.WidthProperty, 100d);
            Setter _fontSizeSetter = new Setter(Button.FontSizeProperty, 12d);
            Setter _foreGroundSetter = new Setter(Button.ForegroundProperty, Brushes.Blue);

            _buttonStyle.Setters.Add(_heightSetter);
            _buttonStyle.Setters.Add(_widthSetter);
            _buttonStyle.Setters.Add(_fontSizeSetter);
            _buttonStyle.Setters.Add(_foreGroundSetter);
            _buttonStyle.Setters.Add(_heightSetter);

            this.button1.Style = _buttonStyle;
            this.button2.Style = _buttonStyle;
            this.button3.Style = _buttonStyle;
            this.button4.Style = _buttonStyle;
            this.button5.Style = _buttonStyle;

        }
    }
}
