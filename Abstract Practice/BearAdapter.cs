/* Name: Enrique Tejeda
 * Date: 9/13/2020
 * Filename: BearAdapter.cs
 * Description: The class inherits from the interface ToyBear. It creates a Bear object so that in the constructor and hug function
 *              it will be able to access Bear's functions. Hug's implementation will call Bear's maul function.
 */


using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Abstract_Practice
{
    class BearAdapter : ToyBear
    {
        Bear bear;
        public BearAdapter(Bear bear)
        {
            this.bear = bear;
        }
        public void hug()
        {
            bear.maul();
        }
    }
}
