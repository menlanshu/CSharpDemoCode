using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Csharp8Demo
{
    public struct Rectangle
    {
        public double Length { get; set; }
        public double Height { get; set; }

        public double Area()
        {
            return Length * Height;
        }
    }
}
