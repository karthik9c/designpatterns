using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.decorator
{
    public class EncryptFile : FileDecorator
    {
        public EncryptFile(IFile file) : base(file)
        {
        }
        public void Read(string fileName)
        {
            Console.WriteLine("Decrypting file");
            base.read(fileName);
        }
        public void Write(string filename, string content)
        {
            Console.WriteLine("Encrypting file");
            base.Write(filename, content);
        }
    }
}
