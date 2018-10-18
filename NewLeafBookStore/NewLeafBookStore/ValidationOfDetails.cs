using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NewLeafBookStore
{
    partial class Books
    {
        public string ValidateName(string name)
        {

            string pattern = @"^([A-Z][a-z]{0,15})$";
            Match match = Regex.Match(name, pattern);
            if (match.Success)
            {
                return name;
            }
            Console.WriteLine("Please enter name(e.g Gourab Sinha)");
            return ValidateName(Console.ReadLine());

        }
        public string ValidatePrice(string price)
        {
                string pattern = @"^[1-9][0-9]{1,2}[.][0-9][0-9]$";
                Match match = Regex.Match(price, pattern);
                if (match.Success && Convert.ToDouble(price) >= 10)
                {
                    return price;
                }
                Console.WriteLine("Invalid Input");
                Console.WriteLine("Please price again(e.g 100.15)");
                return ValidatePrice(Console.ReadLine());
        }
        public string ValidateISBN(string isbn)
        {
            string pattern = @"^[I][S][B][N][0-9]{5}$";
            Match match = Regex.Match(isbn, pattern);
            if (match.Success)
            {
                return isbn;
            }
            Console.WriteLine("Please enter ISBN no (e.g ISBN01234)");
            return ValidatePrice(Console.ReadLine());
        }
    }
}
