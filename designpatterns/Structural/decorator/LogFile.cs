using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.decorator
{
    public class LogFile : FileDecorator
    {
        public LogFile(IFile file): base(file) { }
        public void read(string filename)
        {
            //Log the read operation
            base.read(filename);

        }

        public void Write(string filename, string content)
        {
            //Log the write operation
            base.Write(filename, content);
        }
    }
}
