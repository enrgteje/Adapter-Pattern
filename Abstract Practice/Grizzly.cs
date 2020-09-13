using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Practice
{
    class Grizzly : Bear
    {
        public void hibernate()
        {
            Console.WriteLine("Grizzly is hibernating.");
        }

        public void maul()
        {
            Console.WriteLine("Grizzly is mauling their enemy to death.");
        }
    }
}
