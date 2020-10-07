using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace CodeWithCompiledMarkup.MarkupExtensions
{
    public class ButtonContentValueProviderExtension:MarkupExtension
    {
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            Utility.ButtonContentProvider _provider = new Utility.ButtonContentProvider();
            return _provider.GetButtonContentText();
        }
    }
}
