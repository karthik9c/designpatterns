using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Prototype
{
    public class Rectangle : IShapePrototype
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public string Color { get; set; }
        public string Name { get; set; }

        public Rectangle(int length, int width, string color, string name) 
        {
            Length = length;
            Width = width;
            Color = color;
            Name = name;
        }
        public IShapePrototype Clone()
        {
            return (IShapePrototype)this.MemberwiseClone();
        }

        public void Render()
        {
            Console.WriteLine($"Its rectanle with {Length} {Width}{Color} {Name}");
        }
    }
}
