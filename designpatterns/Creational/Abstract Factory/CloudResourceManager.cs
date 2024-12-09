using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Abstract_Factory
{
    public class CloudResourceManager
    {
        readonly IDatabase _database;
        readonly IStorage _storage;
        public CloudResourceManager(ICloudFactory cloudFactory) 
        {
            _database = cloudFactory.CreateDatabase();
            _storage = cloudFactory.CreateFileStorage();
        }

        public void InsertData(string key, string value)
        {
            _database.InsertData(key, value);
        }

        public void Upload(string file, byte[] data) 
        {
            _storage.Upload(file, data);
        }

    }
}
