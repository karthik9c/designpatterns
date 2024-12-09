using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Abstract_Factory
{
    public class AzureCloudFactory : ICloudFactory
    {
        public IDatabase CreateDatabase()
        {
            return new CosmosDB();
        }

        public IStorage CreateFileStorage()
        {
            return new BlobStorage();
        }
    }
}
