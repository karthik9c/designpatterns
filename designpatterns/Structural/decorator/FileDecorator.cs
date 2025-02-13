using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.decorator
{
    public abstract class FileDecorator : IFile
    {
        protected IFile file;
        public FileDecorator(IFile file)
        {
            this.file = file;
        }
        public void read(string filename)
        {
            file.read(filename);
        }

        public void Write(string filename, string content)
        {
            file.Write(filename, content);
        }
    }
}
