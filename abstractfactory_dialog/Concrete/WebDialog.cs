using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using abstractfactory_dialog.Abstract;

namespace abstractfactory_dialog.Concrete
{
    public class WebDialog : Dialog
    {
        public override void Render()
        {
            Console.WriteLine("WebD");
        }
        public override IButton CreateButton()
        {
            return new HtmlButton();
        }
    }
}
