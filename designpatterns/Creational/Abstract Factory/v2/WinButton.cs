using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Abstract_Factory.v2
{
    class WinButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("WinButton");
        }
    }
}
