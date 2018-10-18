using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLeafBookStore
{
    class BooksFeatures
    {
        public void BookFeaturesMenu()
        {
            while (true)
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
                            ComputerBooks book1 = new ComputerBooks();
                            Console.WriteLine(Convert.ToString(book1.GetType()));
                            Console.WriteLine("Book name type: " + Convert.ToString(new Books().BookName.GetType()));
                            Console.WriteLine("Author name type: " + Convert.ToString(new Books().AuthorName.GetType()));
                            Console.WriteLine("Price type: " + Convert.ToString(new Books().PriceBook.GetType()));
                            break;
                        case 2:
                            PhysicsBooks book2 = new PhysicsBooks();
                            Console.WriteLine(Convert.ToString(book2.GetType()));
                            Console.WriteLine("Book name type: " + Convert.ToString(new Books().BookName.GetType()));
                            Console.WriteLine("Author name type: " + Convert.ToString(new Books().AuthorName.GetType()));
                            Console.WriteLine("Price type: " + Convert.ToString(new Books().PriceBook.GetType()));
                            break;
                        case 3:
                            ChemistryBooks book3 = new ChemistryBooks();
                            Console.WriteLine("Book name type: " + Convert.ToString(new Books().BookName.GetType()));
                            Console.WriteLine("Author name type: " + Convert.ToString(new Books().AuthorName.GetType()));
                            Console.WriteLine("Price type: " + Convert.ToString(new Books().PriceBook.GetType()));
                            break;
                        case 4:
                            MathsBooks book4 = new MathsBooks();
                            Console.WriteLine(Convert.ToString(book4.GetType()));
                            Console.WriteLine("Book name type: " + Convert.ToString(new Books().BookName.GetType()));
                            Console.WriteLine("Author name type: " + Convert.ToString(new Books().AuthorName.GetType()));
                            Console.WriteLine("Price type: " + Convert.ToString(new Books().PriceBook.GetType()));
                            break;
                        case 5:
                            BiologyBooks book5 = new BiologyBooks();
                            Console.WriteLine(Convert.ToString(book5.GetType()));
                            Console.WriteLine("Book name type: " + Convert.ToString(new Books().BookName.GetType()));
                            Console.WriteLine("Author name type: " + Convert.ToString(new Books().AuthorName.GetType()));
                            Console.WriteLine("Price type: " + Convert.ToString(new Books().PriceBook.GetType()));
                            break;
                        case 6:
                            BooksOthers book6 = new BooksOthers();
                            Console.WriteLine(Convert.ToString(book6.GetType()));
                            Console.WriteLine("Book name type: " + Convert.ToString(new Books().BookName.GetType()));
                            Console.WriteLine("Author name type: " + Convert.ToString(new Books().AuthorName.GetType()));
                            Console.WriteLine("Price type: " + Convert.ToString(new Books().PriceBook.GetType()));
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
