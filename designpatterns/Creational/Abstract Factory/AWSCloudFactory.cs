using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Abstract_Factory
{
    public class AWSCloudFactory : ICloudFactory
    {
        public IDatabase CreateDatabase()
        {
            return new DynamoDB();
        }

        public IStorage CreateFileStorage()
        {
            return new S3Storage();
        }
    }
}
