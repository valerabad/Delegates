using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    delegate double AverageDelegate(int arg1, int arg2, int arg3);
    delegate int LengthLogin(string s);
    delegate bool BoolPassword(string s1, string s2);
    delegate double Operations(double a, double b);

    partial class Program
    {                
        static void Main(string[] args)
        {
            Console.WriteLine("Enter task:");
            int task;
            int.TryParse(Console.ReadLine(), out task);
            switch (task)
            {
                case 1:
                    AverageDelegate average = CodeBlock();
                    Console.WriteLine(average(10,12,14));
                    Console.WriteLine(average(1, 15, 15));
                    break;
                case 2:                                        
                    double a = 10, b=12;                    

                    Operations Add = (v1, v2) => v1 + v2;
                    Console.WriteLine( Add(a,b));

                    Add = (v1, v2) => v1 - v2;
                    Console.WriteLine(Add(a, b));

                    Add = (v1, v2) => v1 * v2;
                    Console.WriteLine(Add(a, b));

                    Add = (v1, v2) =>
                        {
                            if (v2 != 0)
                                return v1 / v2;
                            else
                            {
                                Console.WriteLine("Error: division by zero. Exit code: -1");
                                return -1;
                            }
                        };
                    Console.WriteLine(Add(a, b));
                    
                    break;
                case 3:
                    break;
            }            
            Console.ReadKey();
        }
    }
}
