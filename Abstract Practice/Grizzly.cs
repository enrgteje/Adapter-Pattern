/* Name: Enrique Tejeda
 * Date: 9/13/2020
 * Filename: Grizzly.cs
 * Description: The class inherits from the interface Bear and implements the hibernate and maul functions.
 */

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
