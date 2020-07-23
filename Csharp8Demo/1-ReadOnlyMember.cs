using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp8Demo
{
    public struct Rectangle
    {
        public double Length { get; set; }
        public double Height { get; set; }

        // Read only
        public readonly double Area()
        {
            return Length * Height;
        }
    }
}
