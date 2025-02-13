using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.bridge.v2
{
    public abstract class Shape
    {
        protected ITool tool;
        public Shape(ITool tool)
        {
            this.tool = tool;
        }

        public abstract void Draw();
    }
}
