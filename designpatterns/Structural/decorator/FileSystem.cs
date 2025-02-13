using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.decorator
{
    public class FileSystem : IFile
    {
        public void read(string filename)
        {
            throw new NotImplementedException();
        }

        public void Write(string filename, string content)
        {
            throw new NotImplementedException();
        }
    }
}
