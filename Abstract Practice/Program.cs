/* Name: Enrique Tejeda
 * Date: 9/13/2020
 * Filename: Program.cs
 * Description: Creates 3 object to test and calls the functions of each object.
 */

using System;

namespace Abstract_Practice
{
    class Program
    {
        static void Main()
        {
            Bear grozzly = new Grizzly();
            ToyBear teddy = new TeddyBear();
            ToyBear grizzlyTeddy = new BearAdapter(grozzly);

            Console.WriteLine("Grizzly bear test:");
            grozzly.hibernate();
            grozzly.maul();

            Console.WriteLine("\nTeddy bear test:");

            teddy.hug();

            Console.WriteLine("\nBear adapter test:");

            grizzlyTeddy.hug();
        }
    }
}
