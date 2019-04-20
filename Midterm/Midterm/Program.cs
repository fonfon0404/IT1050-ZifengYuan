using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            {//2
                //If statement- Execute the statement if the statement is true, otherwise it will be skipped.
                //While loop- The program executes the loop statement until the condition is not true, and it is used in cases where we are not sure how many times the loop needs to be executed.
                //For loop- Basically the same as the while loop, the program executes the loop statement until the condition is not true, but the for loop is used in cases where we know how many times the loop needs to be executed, and we can add some control conditions in the loop.
            }

            {//3
                /*int i = 2;
                Boolean keepLooping = true;
                while (keepLooping)
                {
                    if (i <= 1)
                        keepLooping = false;
                    i++;
                    Console.WriteLine(i);
                }*/
            }

            {//4
                int x = 1;
                while (x <= 128)
                {
                    Console.WriteLine("[{0}]",x);
                    x = x * 2;
                    if (x > 64)
                    break;
                }
            }

            {//5
                string n = ",";
                int x;
                for (x = 49; x >= 1; x--)
                {
                    Console.Write(x);
                    if (x > 1) { Console.Write(n); }
                }
            }
            Console.WriteLine();
            {//6
                int x = 1;
                while (x <= 21)
                {
                    if ((x % 2) == 0 ) { Console.Write(" "); }
                    else if ((x % 2) != 0) { Console.Write(x); }
                    x++;
                }
            }
            Console.WriteLine();
            {//7
                {//do-while
                    int n = 8;
                    int i = 10;
                    do
                    {
                        Console.Write("*");
                        i++;
                    } while (i < n);
                }
                Console.WriteLine();
                {
                    int n = 8;
                    int i = 10;
                    while (i < n)
                    {
                      Console.Write("*");
                      i++;
                    }
                }
                //Executing a do-while loop will output a *, and using the same code in a while loop will not output anything.
                //The reason is that the do-while loop will be executed at least once. But the while loop will check the condition before execution, so it won't output anything for this code.
            }

            {//8
                Boolean icyRain = false;
                Boolean tornadoWarning = false;

                if ( icyRain == false && tornadoWarning == false)
                { Console.WriteLine("Let’s go outside!"); }

            }
            Console.WriteLine();
            {//9
                int n = 1, s, x;
                for (int i = 5; i >= n; i--)
                {
                    for (s = 1; s <= (5 - i); s++) 
                        Console.Write(" ");
                    for (x = 1; x <= i; x++) 
                        Console.Write(x);
                    for (x = (i - 1); x >= 1; x--)
                        Console.Write(x);
                    Console.WriteLine();

                }
            }
            Console.ReadKey();
        }
    }
}
