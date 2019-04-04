using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            {/* 2. The if single-selection statement and the while repetition statement are substantially identical in structure, but the while repetition statement may contain an Increment or Decrement statement.
             * Moreover, if the condition of the statement is true, the if single-selection statement will run the action once and stop, but the while repetition statement will repeat the action until the condition becomes false.
             */
            }

            {//3.
                int Speedlimit;
                int speed;

                Speedlimit = 35;
                speed = 42;

                if (speed > Speedlimit) { Console.WriteLine("SLOW NOW"); }

            
            }

            {//4.
                int isTrue = 10;
               {
                if(isTrue < 11)//"It is True!" outputted
                    Console.WriteLine("It is True!");
                else
                    Console.WriteLine("It is False!");

                if (isTrue < 9)//"It is False!" outputted
                    Console.WriteLine("It is True!");
                else
                    Console.WriteLine("It is False!");
               }
            }

            {//5.
                Console.Write("Enter the temperature in Fahrenheit:");
                double fahrenheit = Convert.ToDouble(Console.ReadLine());

                double celsius = (fahrenheit - 32d) * 5d / 9d;
                Console.WriteLine("Temperature in Celsius is {0}", celsius);

                if (fahrenheit < 40)
                    Console.WriteLine("It is cold");
                if (fahrenheit > 90)
                    Console.WriteLine("It is hot");
            }

            {//6
                int x = 1;
                while (x <= 10)
                {
                    Console.Write("Value ");
                    Console.WriteLine(x);
                    x = x + 1;
                }
            }

            {//7
                int x = 60;
                while (x >= 20)
                {
                    Console.Write("Value ");
                    Console.WriteLine(x);
                    x = x - 1;
                }
            }

            {//8
                int x = 10;
                while (x <= 20)
                {
                    Console.Write("Value ");
                    Console.WriteLine(x);
                    x = x + 2;
                }

            }
            Console.ReadKey();
        }
    }
}
