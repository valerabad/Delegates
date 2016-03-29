using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    delegate double AverageDelegate(int arg1, int arg2, int arg3);        
    delegate double Operations(double a, double b);

    delegate int myDel();
    delegate double AverageMassivDel(myDel[] value);
    

    partial class Program
    {           
        static void Main(string[] args)
        {
            Console.WriteLine("Enter task:");
            int task;
            int.TryParse(Console.ReadLine(), out task);
            switch (task)
            {
                //1 task
                case 1:
                    AverageDelegate average = CodeBlock();
                    Console.WriteLine("Average: {0}", average(10,12,14));
                    Console.WriteLine("Average: {0}", average(1, 15, 15));
                    break;
                //2 task
                case 2:                                        
                    double a = 10, b=12;                    

                    Operations Add = (v1, v2) => v1 + v2;
                    Console.WriteLine("Sum: {0}", Add(a,b));

                    Operations Sub = (v1, v2) => v1 - v2;
                    Console.WriteLine("Sub: {0}", Sub(a, b));

                    Operations Mul = (v1, v2) => v1 * v2;
                    Console.WriteLine("Mul: {0}", Mul(a, b));

                    Operations Div = (v1, v2) =>
                        {
                            if (v2 != 0)
                                return v1 / v2;
                            else
                            {
                                Console.WriteLine("Error: division by zero. Exit code: -1");
                                return -1;
                            }
                        };
                    Console.WriteLine("Div: {0}", Div(a, b));
                    
                    break;
                //3 task
                case 3:                    
                    myDel[] massivDelegates = new myDel[3];
                    massivDelegates[0] = new myDel(RandomValue1);
                    massivDelegates[1] = new myDel(RandomValue2);
                    massivDelegates[2] = new myDel(RandomValue3);

                    AverageMassivDel averageMas = AverageMasiv();
                    Console.WriteLine("Average: {0}", averageMas(massivDelegates));

                    break;
            }            
            Console.ReadKey();
        }
    }
}
