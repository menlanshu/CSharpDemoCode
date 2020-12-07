using System;
using System.Collections.Generic;
using System.Text;

namespace ISPDemo
{
    public interface ILibraryItem
    {
        public int LibraryItemId { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
    }
}
