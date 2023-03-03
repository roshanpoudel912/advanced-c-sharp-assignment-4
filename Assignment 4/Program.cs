using System.Collections.Generic;
using System.Drawing;

namespace Assignment_4
{
    internal class Program
    {
        static List<IRental> rentalItems = new List<IRental>();

        static void Main(string[] args)
        {
            static void ListAllItems()
            {
                Console.WriteLine("All rental items:");
                foreach (IRental item in rentalItems)
                {
                    Console.WriteLine(item.ToString());
                }
            }

            static void ListAvailableItems()
            {
                Console.WriteLine("Available rental items:");
                foreach (IRental item in rentalItems)
                {
                    if (String.IsNullOrEmpty(item.RenterName))
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
            }

            static void RentItem()
            {
                Console.Write("Enter the Id of the item to rent: ");

                if (!int.TryParse(Console.ReadLine(), out int itemId))
                {
                    Console.WriteLine("ID can't be blank or must be number");
                    return;
                }

               
               
                IRental rentalItem = rentalItems.Find(item => item.Id == itemId);
             
                if (rentalItem == null)
                {
                    Console.WriteLine("Item not found. Please try again.");
                    return;
                }


                if (!String.IsNullOrEmpty(rentalItem.RenterName))
                {
                    Console.WriteLine("Item is not available for rent. Please select another item.");
                    return;
                }

                Console.Write("Enter name of the renter: ");

                string renterName = Console.ReadLine();

                if(String.IsNullOrEmpty(renterName))
                {
                    Console.WriteLine("Name can't be blank");
                    return;
                }

                rentalItem.RenterName = renterName;
                Console.WriteLine($"Id {rentalItem.Id} Item '{rentalItem.Name}' has been rented to {rentalItem.RenterName}");
            }

            // Add 10 rental items to the list
            rentalItems.Add(new Vehicle(1, "Honda","", 200.0, "Civic", 2018));
            rentalItems.Add(new Vehicle(2, "Hyundai","", 300.0, "Tucson", 2022));
            rentalItems.Add(new Vehicle(3, "Toyota","", 500.0, "Corolla", 2017));
            rentalItems.Add(new Tool(4, "Hammer","", 6.0, "Hand Tools"));
            rentalItems.Add(new Tool(5, "Saw","", 12.0, "Hand Tools"));
            rentalItems.Add(new Tool(6, "Drill","", 26.0, "Power Tools"));
            rentalItems.Add(new RentalItem(7, "Bike","", 35.0));
            rentalItems.Add(new RentalItem(8, "Boat","", 80.0));
            rentalItems.Add(new RentalItem(9, "Utensils","", 100.0));
            rentalItems.Add(new RentalItem(10, "Snow Blowers","", 600.0));

            int choice = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("*** Rental Agency ***");
                Console.WriteLine("1. List all rental items");
                Console.WriteLine("2. List all available items");
                Console.WriteLine("3. Rent an item");
                Console.WriteLine("4. Exit");
                Console.Write("Please select an option >> ");
                

                if (!int.TryParse(Console.ReadLine(), out int choices))
                {
                    Console.WriteLine("ID can't be blank or must be number");
                    return;
                }

                choice = choices;

                switch (choice)
                {
                    case 1:
                        ListAllItems();
                        break;
                    case 2:
                        ListAvailableItems();
                        break;
                    case 3:
                        RentItem();
                        break;
                    case 4:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            } while (choice != 4);

        }
    }
}
