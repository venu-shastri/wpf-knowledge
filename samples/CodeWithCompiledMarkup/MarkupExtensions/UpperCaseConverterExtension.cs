using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace CodeWithCompiledMarkup.MarkupExtensions
{
    public class UpperCaseConverterExtension : MarkupExtension
    {
        string data;
        public UpperCaseConverterExtension() { }
        public UpperCaseConverterExtension(string data)
        {
            this.data = data;
        }
        public string Data
        {
            get { return this.data; }
            set { this.data = value; }
        }
        public override object ProvideValue(IServiceProvider serviceProvider)
        {

            return this.data.ToUpper();

        }
    }
}
