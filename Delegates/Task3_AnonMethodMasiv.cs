using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    partial class Program
    {
        static AverageMassivDel AverageMasiv()
        {
            AverageMassivDel mas = delegate(myDel[] masDel)
                {
                    double result = 0, count = masDel.Length;
                    Console.WriteLine("Сгенерированные числа: ");
                    for (int i=0; i<masDel.Length; i++)
                    {
                        int randValue = masDel[i]();
                        result += randValue;
                        Console.WriteLine(randValue);
                    }
                    result /= count; 
                    return  result;
                };
            return mas;
        }
    }
}