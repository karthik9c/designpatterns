using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Abstract_Factory
{
    public class DynamoDB : IDatabase
    {
        public void InsertData(string key, object value)
        {
            Console.WriteLine($"Insert data {key}, {value}");
        }
    }

    public class S3Storage : IStorage
    {
        public void Upload(string file, byte[] data)
        {
            Console.WriteLine($"Data uploded");
        }
    }
}
