using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{   
    partial class Program
    {
        static AverageDelegate CodeBlock()
        {
            // вызов анонимного метода
            AverageDelegate del = delegate(int arg1, int arg2, int arg3)  // этот м-д должен соответсвовать сигнатуре делегата
            {
                double result = 0;
                result = (arg1 + arg2 + arg3) / 3d;
                return result;
            };
            return del;
        }
    }
}