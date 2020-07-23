using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class AccessDemo
    {

        // Private method usage demo test
        private void Demo()
        {
            PrivateDemo();
        }

        // Only can be used in this class internally
        private void PrivateDemo()
        {

        }

        // Available in this class
        // Not available in this assembly package
        // Available in inherit class
        private protected void PrivateProtectedDemo()
        {

        }

        // can be called in this class and classes that inherit from this class
        protected void ProtectedDemo()
        {

        }

        // avaiable in assembly and inherit class
        protected internal void ProtectedInternalDemo()
        {

        }


        // the entire project that I belong to can acces to this method
        internal void InternalDemo()
        {

        }

        // Anybody can talke to me
        public void PublicDemo()
        {

        }






    }
}
