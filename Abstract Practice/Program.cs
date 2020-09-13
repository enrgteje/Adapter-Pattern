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

            grozzly.hibernate();
            grozzly.maul();

            Console.WriteLine();

            teddy.hug();

            Console.WriteLine();

            grizzlyTeddy.hug();
        }
    }
}
