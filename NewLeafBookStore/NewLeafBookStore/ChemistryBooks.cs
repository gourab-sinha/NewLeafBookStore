using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLeafBookStore
{
    class ChemistryBooks:Books,IBookInfo
    {
        public void GetBookDetails()
        {
            Console.WriteLine("Please Enter Book Name: ");
            try
            {
                BookName = ValidateName(Console.ReadLine());
                if (BookName.Length == 1 || BookName.Length == 0)
                {
                    throw new InvalidNameException("Single Character or null");
                }
            }
            catch (InvalidNameException e)
            {
                Console.WriteLine(e.ToString());
                return;
            }
            try
            {
                Console.WriteLine("Please Enter Author Name:");
                AuthorName = ValidateName(Console.ReadLine());
                if (AuthorName.Length == 1 || AuthorName.Length == 0)
                {
                    throw new InvalidNameException("Single Character or null");
                }
            }
            catch (InvalidNameException e)
            {
                Console.WriteLine(e.ToString());
                return;
            }
            try
            {
                Console.WriteLine("Please Enter Price (e.g: 100.00):");
                PriceBook = Convert.ToDouble(ValidatePrice(Console.ReadLine()));
                if (PriceBook >= 1000.00)
                {
                    throw new InvalidPriceException("More than limit");
                }
                FinalBookPrice = CalculatePrice(offerpercent: 5, vatpercent: 3);
            }
            catch (InvalidPriceException e)
            {
                Console.WriteLine(e.ToString());
                return;
            }
            try
            {
                Console.WriteLine("Please Enter ISBN No:");
                ISBN = ValidateISBN(Console.ReadLine());
                if (ISBN == "ISBN00000")
                    throw new InvalidISBNException("Cannot be ISBN00000");

            }
            catch (InvalidISBNException e)
            {
                Console.WriteLine(e.ToString());
                return;
            }

        }
    }
}
