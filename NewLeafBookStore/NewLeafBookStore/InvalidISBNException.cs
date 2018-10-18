using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLeafBookStore
{
    class InvalidISBNException:Exception
    {
        public InvalidISBNException(string message):base(message)
        {

        }
    }
}
