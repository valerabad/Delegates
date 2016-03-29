using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    partial class Program
    {
        static int RandomValue1()
        {
            Random rndm = new Random();
            return rndm.Next(100);
        }

        static int RandomValue2()
        {
            Random rndm = new Random();
            return rndm.Next(50);
        }

        static int RandomValue3()
        {
            Random rndm = new Random();
            return rndm.Next(10);
        }
    }
}