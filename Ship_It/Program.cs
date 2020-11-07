using System;
using System.Collections;
using System.Collections.Generic;

namespace Ship_It
{
    class Program
    {
        static void Main(string[] args)
        {

            Shipper<IShippable> shipper = new Shipper<IShippable>();

            string printOptions = "Choose from the following options:\n\n1.   Add a Bicycle to the shipment\n2.   Add a Lawn Mower to the Shipment\n3.   Add a Baseball Glove to the shipment\n4.   Add Crackers to the shipment\n5.   List Shipment Items\n6.   Compute Shipping Charges\n7.   Quit";
            
            Console.WriteLine(printOptions);
            string input = Console.ReadLine();
            while (input != "7")
            {
        // Adds Bicycle
                if (input == "1")
                {
                    shipper.Add(new Bicycle());
                    Console.WriteLine("\n1 Bicycle has been added\nPRESS ANY KEY TO RETURN TO THE LIST");
                    Console.ReadKey();
                    Console.WriteLine();
                }
        // Adds Lawn Mower
                else if (input == "2")
                {
                    shipper.Add(new LawnMower());
                    Console.WriteLine("\n1 Lawn Mower has been added\nPRESS ANY KEY TO RETURN TO THE LIST");
                    Console.ReadKey();
                    Console.WriteLine();
                }
        // Adds Baseball Glove
                else if (input == "3")
                {
                    shipper.Add(new BaseballGlove());
                    Console.WriteLine("\n1 Baseball Glove has been added\nPRESS ANY KEY TO RETURN TO THE LIST");
                    Console.ReadKey();
                    Console.WriteLine();
                }
        // Adds Cracker
                else if (input == "4")
                {
                    shipper.Add(new Cracker());
                    Console.WriteLine("\n1 Cracker has been added\nPRESS ANY KEY TO RETURN TO THE LIST");
                    Console.ReadKey();
                    Console.WriteLine();
                }
        // List Shipment Items
                else if (input == "5")
                {
                    int bikeTotal = 0;
                    int mowerTotal = 0;
                    int gloveTotal = 0;
                    int crackerTotal = 0;

                    foreach (IShippable _product in shipper.ShipmentTotal)
                    {
                        if (_product.Product.Equals("Bicycle"))
                        {
                            bikeTotal++;
                        }
                        else if (_product.Product.Equals("Lawn Mower"))
                        {
                            mowerTotal++;
                        }
                        else if (_product.Product.Equals("Baseball Glove"))
                        {
                            gloveTotal++;
                        }
                        else
                        {
                            crackerTotal++;
                        }
                    }
                    Console.WriteLine();
                    if (bikeTotal == 1)
                    {
                        Console.WriteLine(bikeTotal + " " + new Bicycle().Product + " sold.");
                    }
                    else
                    {
                        Console.WriteLine(bikeTotal + " " + new Bicycle().Product + "s sold.");
                    }
                    if (mowerTotal == 1)
                    {
                        Console.WriteLine(mowerTotal + " " + new LawnMower().Product + " sold.");
                    }
                    else
                    {
                        Console.WriteLine(mowerTotal + " " + new LawnMower().Product + "s sold.");
                    }
                    if (gloveTotal == 1)
                    {
                        Console.WriteLine(gloveTotal + " " + new BaseballGlove().Product + " sold.");
                    }
                    else
                    {
                        Console.WriteLine(gloveTotal + " " + new BaseballGlove().Product + "s sold.");
                    }
                    Console.WriteLine(crackerTotal + " " + new Cracker().Product + " sold.");
                    Console.WriteLine();
                    Console.WriteLine("PRESS ANY KEY TO RETURN TO THE LIST");
                    Console.ReadKey();
                    Console.WriteLine();
                }
        // Compute Shipping Cost
                else if (input == "6")
                {
                    decimal TotalCost = 0;
                    foreach (IShippable i in shipper.ShipmentTotal)
                    {
                        TotalCost += i.ShipCost; 
                    }

                    Console.WriteLine("\nTotal shipping costs for this order are $" + TotalCost);
                    Console.WriteLine("\nPRESS ANY KEY TO RETURN TO THE LIST");
                    Console.ReadKey();
                    Console.WriteLine();
                }
        // Bad input handling
                else 
                {
                    Console.WriteLine("Please enter a valid number..."); 
                }

                Console.WriteLine(printOptions);
                input = Console.ReadLine();
            }
        }
    }
}
