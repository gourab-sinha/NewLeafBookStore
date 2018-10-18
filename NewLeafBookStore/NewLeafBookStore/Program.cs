using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLeafBookStore
{
    interface IBookInfo
    {
        void GetBookDetails();
    }
    partial class Books
    {
        public virtual double CalculatePrice(int offerpercent,int vatpercent = 2)
        {
            double finalBookPrice = priceBook - ((priceBook * offerpercent) / 100) + ((priceBook * vatpercent) / 100);
            return finalBookPrice;
        }
        public virtual void Bill()
        {
            Console.WriteLine("********THANK YOU********");
            Console.WriteLine("Book Name: " + bookName);
            Console.WriteLine("Book Author Name: " + authorName);
            Console.WriteLine("Book Price: " + finalBookPrice);
            Console.WriteLine("*****Have a nice day*****");
        }
    }
    class Program
    {
        enum timings { morning = 5, noon = 12, afternoon = 18};
        public static void Main(string[] args)
        {
            Console.WriteLine("********WELCOME TO NEWLEAF BOOK STORE*********");
            Console.WriteLine("Please enter your first name");
            string userFirstName = new Books().ValidateName(Console.ReadLine());
            Console.WriteLine("Please enter your last name");
            string userLastName = new Books().ValidateName(Console.ReadLine());
            Console.WriteLine("Welcome " + userFirstName + " " + userLastName);
            Console.WriteLine("Current Time: " + DateTime.Now.ToString("h:mm tt"));
            string[] daytime = DateTime.Now.ToString("HH:mm:ss tt").Split(':');
            Action<int> greetings = delegate (int x)
            {
                if (x > (int)timings.morning && x < (int)timings.noon)
                {
                    Console.WriteLine("We wish you a very Good Morning");
                }
                else if (x == (int)timings.noon)
                {
                    Console.WriteLine("We wish you a very Good Noon");
                }
                else if (x > (int)timings.noon && x < (int)timings.afternoon)
                {
                    Console.WriteLine("We wish you a very Good Afternoon");
                }
                else
                {
                    Console.WriteLine("We wish you a very Good Night");
                }
            };
            greetings(Convert.ToInt32(daytime[0]));
            //Console.WriteLine(daytime);

            while (true)
            {
                try
                {
                    Console.WriteLine("PLESE SELECT FROM GIVEN LIST:");
                    Console.WriteLine("#1: BOOK BILLING MENU");
                    Console.WriteLine("#2: BOOKS CATEGORIES AND THEIR FEATURES MENU");
                    Console.WriteLine("#3: BOOKS DETAILS");
                    Console.WriteLine("#4: EXIT");
                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            BookBilling bookbillingmenu = new BookBilling();
                            bookbillingmenu.BookBillingMenu();
                            break;
                        case 2:
                            BooksFeatures bookfeaturesmenu = new BooksFeatures();
                            bookfeaturesmenu.BookFeaturesMenu();
                            break;
                        case 3:
                            BookBilling getBookDetails = new BookBilling();
                            getBookDetails.ShowDetailsMenu();
                            break;
                        case 4:
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
                    Console.WriteLine("Input is invalid");
                }
            }
        }
    }
}
