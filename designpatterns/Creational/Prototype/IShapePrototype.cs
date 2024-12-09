﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Prototype
{
    public interface IShapePrototype
    {
        IShapePrototype Clone();
        void Render();
    }
}
