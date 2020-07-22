using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.InterfaceDemo
{
    // An contract
    // No source code
    // No implementation
    // Default public, so can not add modifier in it
    public interface IProductModel
    {
        string Title { get; set; }
        bool HasOrderBeenCompleted { get; }
        void ShipItem(CustomerModel customer);

    }
}
