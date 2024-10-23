using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Memory
    {
        private static Memory _instance;
        private static readonly object _lock = new object();
        private Memory() 
        { 
            
        }

        public static Memory GetInstance()
        {
            if(_instance == null)
            {
                lock (_lock)
                {
                    if(_instance == null)
                    {
                        _instance = new Memory ();
                    }
                }
               
            }

            return _instance;
        }
    }
}
