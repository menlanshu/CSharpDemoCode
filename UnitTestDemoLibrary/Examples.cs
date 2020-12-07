using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace UnitTestDemoLibrary
{
    public class Examples
    {
        public string ExampleLoadTextFile(string file)
        {
            if(file.Length < 10)
            {
                throw new FileNotFoundException();
            }

            return "The file was correctly loaded.";
        }
    }
}
