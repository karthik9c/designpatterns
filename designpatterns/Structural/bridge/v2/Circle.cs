using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.bridge.v2
{
    public class Circle : Shape
    {
        public Circle(ITool tool) : base(tool)
        {
        }
        public override void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
