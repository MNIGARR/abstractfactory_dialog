using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using abstractfactory_dialog.Abstract;


namespace abstractfactory_dialog.Concrete
{
    public class WindowsButton : IButton
    {
        public void OnClick()
        {
            Console.WriteLine("WButton");
        }

        public void Render()
        {
            Console.WriteLine("WButton");
        }
    }
}
