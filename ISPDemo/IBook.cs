using System;
using System.Collections.Generic;
using System.Text;

namespace ISPDemo
{
    public interface IBook : ILibraryItem
    {
        public int Pages { get; set; }
    }
}
