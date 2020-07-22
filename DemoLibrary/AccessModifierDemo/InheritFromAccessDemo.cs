using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    class InheritFromAccessDemo : AccessDemo
    {
        private void Demo()
        {
            this.ProtectedInternalDemo();
            this.ProtectedDemo();
            this.PublicDemo();
            this.InternalDemo();
            this.PrivateProtectedDemo();
        }
    }
}
