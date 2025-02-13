using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.bridge.v2
{
    public class Rectangle : Shape
    {
        public Rectangle(ITool tool) : base(tool)
        {
        }
        public override void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
