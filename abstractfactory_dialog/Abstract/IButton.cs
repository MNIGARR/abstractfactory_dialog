using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractfactory_dialog
{
    public interface IButton
    {
        public void Render();
        public void OnClick();
    }
}
