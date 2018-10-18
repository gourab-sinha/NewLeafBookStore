using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLeafBookStore
{
    partial class Books
    {
        private string bookName { get; set; } //backing field for book name
        public string BookName
        {
            get { return bookName; }
            set { bookName = value; }
        }
        private string authorName { get; set; } //backing field for author name;
        public string AuthorName
        {
            get { return authorName; }
            set { authorName = value; }
        }
        private double priceBook; // backing field for book price
        public double PriceBook
        {
            get { return priceBook; }
            set
            {
                priceBook = value;
            }
        }
        private string isbn { get; set; } // backing field for isbn no
        public string ISBN
        {
            get { return isbn; }
            set
            {
                isbn = value;
            }
        }
        private double finalBookPrice { get; set; }
        public double FinalBookPrice
        {
            get { return finalBookPrice; }
            set
            {
                finalBookPrice = value;
            }
        }
    }
}
