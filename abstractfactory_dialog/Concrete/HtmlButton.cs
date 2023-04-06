using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractfactory_dialog.Concrete
{
    internal class HtmlButton : IButton
    {
        public void OnClick()
        {
            Console.WriteLine("Html");
        }

        public void Render()
        {
            Console.WriteLine("Html");
        }
    }
}
