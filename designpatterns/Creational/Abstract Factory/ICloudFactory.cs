using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Abstract_Factory
{
    public interface ICloudFactory
    {
        IDatabase CreateDatabase();
        IStorage CreateFileStorage();
    }
}
