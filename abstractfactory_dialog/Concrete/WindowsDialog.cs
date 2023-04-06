using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using abstractfactory_dialog.Abstract;

namespace abstractfactory_dialog.Concrete
{
    public class WindowsDialog : Dialog
    {
        public override void Render()
        {
            Console.WriteLine("WD");
        }
        public override IButton CreateButton()
        {
            return new WindowsButton();
        }
    }
}
