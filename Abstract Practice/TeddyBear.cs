/* Name: Enrique Tejeda
 * Date: 9/13/2020
 * Filename: TeddyBear.cs
 * Description: The class inherits from the interface ToyBear and implements the hug function.
 */


using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Practice
{
    class TeddyBear : ToyBear
    {
        public void hug()
        {
            Console.WriteLine("TeddyBear hugs.");
        }
    }
}
