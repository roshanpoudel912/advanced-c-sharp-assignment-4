using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    internal class RentalItem : IRental
    {
        public string RenterName { get; set; }
        public string Name { get; set; }
        double _price;
        public double Price
        {
            get{ return _price;}
            set { _price = value; }
        }

        public int Id { get; set; }

        public RentalItem(int id, string name, string renterName, double rentPrice)
        {
            Id = id;
            Name = name;
            RenterName = renterName;
            Price = rentPrice;
            
        }

        public override string ToString()
        {
            return $" Id: {Id}, Name: {Name}, Rent Price: {Price:C}, RenterName: {RenterName}";
        }
    }
}
