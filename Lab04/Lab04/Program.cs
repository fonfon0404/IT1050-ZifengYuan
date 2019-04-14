using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class Program
    {
        static void Main(string[] args)
        {
            {//2.
                /* the four basic elements of the counter-controlled repetition is
                 * 1. Control variable - a loop must have a control variable, so a control variable is usually referred to a loop counter.
                 * 2. Initial value - It is a point that started of the control variable.
                 * 3. Increment or Decrement - they are the modification when the control variable loops.
                 * 4. Loop continuation - It is a condition that decides the control variable continues to loop or stop.
                 */
            }

            {//3.
                //The structure and type of the while and for repetition statements are roughly the same, the for repetition statement is cleaner and more readable than the while statement, but the developer must create a new variable in the for repetition statement, not in the while statement.
            }

            {//4.
                int x;
                do
                {
                    Console.WriteLine("number");
                    x = Convert.ToInt32(Console.ReadLine());
                }
                while (x < 5);
                Console.WriteLine("Greater than or equal to 5, the loop will stop");

                //The above is a do-while statement to check if the number is less than 5 by entering a integer, if the input integer is less than 5, the user can continue to enter until the number entered is greater than or equal to 5, the message "Greater than or equal to 5, the loop will stop" will be displayed.
            }

            {//5
                for(int i = 1; i <= 100; i++)
                {
                    Console.Write(i);
                    {
                        if((i%2)==0)
                        { Console.Write(" is even"); }
                        else if ((i%2)!=0)
                        { Console.Write(" is odd"); }
                        Console.WriteLine();
                    }
                }

            }

            {//6
                Console.Write("Please enter a temperature ");
                int x = Convert.ToInt32(Console.ReadLine());

                if (x < 10) { Console.WriteLine("Polar Bear"); }
                else if (x < 20) { Console.WriteLine("Penguin"); }
                else if (x < 40) { Console.WriteLine("Moose"); }
                else if (x < 50) { Console.WriteLine("Reindeer"); }
                else if (x < 60) { Console.WriteLine("Deer"); }
                else if (x < 70) { Console.WriteLine("Turtle"); }
                else if (x < 80) { Console.WriteLine("Lion"); }
                else if (x < 90) { Console.WriteLine("Fish"); }
                else { Console.WriteLine("Bug"); }
            }

            {//7
                int i = 10;
                while (i < 21)
                {
                    Console.WriteLine(i);
                    i = i + 1; //or i++;
                }
            }

            {//8
                for (int i = 0; i < 101; i++)
                {   //Missing brackets
                    Console.WriteLine(i);
                    Console.WriteLine("********");
                }

            }
                Console.ReadKey();
        }
    }
}
