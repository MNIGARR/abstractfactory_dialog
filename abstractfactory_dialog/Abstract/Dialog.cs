using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractfactory_dialog.Abstract
{
    public abstract class Dialog 
    {
        public virtual void  Render() {
            Console.WriteLine("Render");
        }
        public abstract IButton CreateButton();

        
    }
}
