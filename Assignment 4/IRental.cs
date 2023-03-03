using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    internal interface IRental
    {
        int Id { get; set; }
        string Name { get; set; }
        double Price { get; set; }
        string RenterName { get; set; }
    }
}
