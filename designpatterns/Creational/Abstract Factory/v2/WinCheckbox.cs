using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Abstract_Factory.v2
{
    class WinCheckbox : ICheckbox
    {
        public void Paint()
        {
            Console.WriteLine("WinCheckbox");
        }
    }
}
