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
