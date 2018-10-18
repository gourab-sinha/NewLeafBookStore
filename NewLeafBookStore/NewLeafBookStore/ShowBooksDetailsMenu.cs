using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLeafBookStore
{
    partial class BookBilling
    {
        public void ShowDetailsMenu()
        {
           
            while (true)
            {
                try
                {
                    Console.WriteLine("Please select from below list to view details");
                    Console.WriteLine("#1: COMPUTER BOOKS");
                    Console.WriteLine("#2: PHYSICS BOOKS");
                    Console.WriteLine("#3: CHEMISTRY BOOKS");
                    Console.WriteLine("#4: MATHS BOOKS");
                    Console.WriteLine("#5: BIOLOGY BOOKS");
                    Console.WriteLine("#6: OTHER BOOKS");
                    Console.WriteLine("#7: RETURN TO MAIN MENU");
                    Console.WriteLine("#8: EXIT");
                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            if(listComputerBooks.Capacity >= 1)
                            foreach (var book in listComputerBooks)
                            {
                                book.Bill();
                            }
                            else
                                Console.WriteLine("No billing details available");
                            break;
                        case 2:
                            if(listPhysicsBooks.Capacity >= 1)
                            foreach (var book in listPhysicsBooks)
                            {
                                book.Bill();
                            }
                            else
                                Console.WriteLine("No billing details available");
                            break;
                        case 3:
                            if(listChemitryBooks.Capacity >= 1)
                            foreach (var book in listChemitryBooks)
                            {
                                book.Bill();
                            }
                            else
                                Console.WriteLine("No billing details available");
                            break;
                        case 4:
                            if(listMathsBooks.Capacity >=1 )
                            foreach (var book in listMathsBooks)
                            {
                                book.Bill();
                            }
                            else
                                Console.WriteLine("No billing details available");
                            break;
                        case 5:
                            if(listBiologyBooks.Capacity >= 1)
                            foreach (var book in listBiologyBooks)
                            {
                                book.Bill();
                            }
                            else
                                Console.WriteLine("No billing details available");
                            break;
                        case 6:
                            if(listOtherBooks.Capacity >= 1)
                            foreach (var book in listOtherBooks)
                            {
                                book.Bill();
                            }
                            else
                                Console.WriteLine("No billing details available");
                            break;
                        case 7:
                            return;
                        case 8:
                            Console.WriteLine("Thank you for visiting us");
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Option not available");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }
    }
}
