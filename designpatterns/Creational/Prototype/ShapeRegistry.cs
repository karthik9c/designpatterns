using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Prototype
{
    public class ShapeRegistry
    {
        public Dictionary<string, IShapePrototype> Shapes = new Dictionary<string, IShapePrototype>();

        public void Add(string name, IShapePrototype shapePrototype)
        {
            Shapes.Add(name, shapePrototype);
        }

        public IShapePrototype Get(string name)
        {
            return Shapes[name];
        }
    }
}
