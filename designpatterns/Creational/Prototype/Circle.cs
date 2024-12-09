using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Prototype
{
    public class Circle : IShapePrototype
    {
        public int Radius { get; set; }
        public string Color { get; set; }
        public string Name { get; set; }
        public IShapePrototype Clone()
        {
            return (IShapePrototype)this.MemberwiseClone();
        }

        public Circle(int radius, string color, string name)
        {
            Radius = radius;
            Color = color;
            Name = name;
        }

        public void Render()
        {
            Console.WriteLine($"Its circle with {Radius} {Color} {Name}");
        }
    }
}
