using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.decorator
{
    public interface IFile
    {
        void Write(string filename, string content);
        void read(string filename);
    }
}
