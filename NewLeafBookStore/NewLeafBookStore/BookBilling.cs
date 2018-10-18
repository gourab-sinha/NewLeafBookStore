using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLeafBookStore
{
    partial class BookBilling
    {
        public void BookBillingMenu()
        {
            while(true)
            {

                try
                {
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
                            ComputerBooks computerbooks = new ComputerBooks();
                            computerbooks.GetBookDetails();
                            listComputerBooks.Add(computerbooks);
                            //foreach (var item in listComputerBooks)
                            //{
                            //    item.Bill();
                            //}
                            break;
                        case 2:
                            PhysicsBooks physicsbooks = new PhysicsBooks();
                            physicsbooks.GetBookDetails();
                            listPhysicsBooks.Add(physicsbooks);
                            break;
                        case 3:
                            ChemistryBooks chemistrybooks = new ChemistryBooks();
                            chemistrybooks.GetBookDetails();
                            listChemitryBooks.Add(chemistrybooks);
                            break;
                        case 4:
                            MathsBooks mathbooks = new MathsBooks();
                            mathbooks.GetBookDetails();
                            listMathsBooks.Add(mathbooks);
                            break;
                        case 5:
                            BiologyBooks biologybooks = new BiologyBooks();
                            biologybooks.GetBookDetails();
                            listBiologyBooks.Add(biologybooks);
                            break;
                        case 6:
                            BooksOthers otherbooks = new BooksOthers();
                            otherbooks.GetBookDetails();
                            listOtherBooks.Add(otherbooks);
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
                catch(Exception e)
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }
        
    }
}
