using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int sum;

            Console.WriteLine("{0}\n{1}", "Hello world!", "from [Zifeng]");
            Console.WriteLine("\t");

            Console.Write("Hello world");
            Console.Write("\t");
            Console.Write("from [Zifeng]");

            Console.WriteLine("\t");
            Console.WriteLine("\t");

            Console.Write("Enter first intger: "); 
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second intger: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            sum = number1 + number2;

            Console.WriteLine( "Sum is {0}", sum );


            Console.ReadKey();

            /* a. One way to run the program is to click the start button or press F5 in the Visual Studio.
             *    Another way is when the developer runs the Developer Command Prompt for VS and enter the command of the program, if the program works fine which is no compilation errors, an executable file will be created and the program can be run through this file. */

            /* b. An integer type variable is an integer number without decimal point, like 1 or 0.
             *    A double or floating-point variable is a number that has the decimal point, like 1.0 or 1.1. */

            /* c. DisplayMessage() is one of the method in chapter4 that used for display message of the gradebook.
             * Example:
              public class GradeBook
             { 
                // display a welcome message to the GradeBook user 
 
 	            { 
 	             Console.WriteLine( "Welcome to the grade book for\n{0}!", courseName ); 
 	            } // end method DisplayMessage 
              } // end class GradeBook                                                      
                    */

            /* d.  To read the value of an instance variable, we create method called a _get_ accessor.  To assign a value ton instance variable, we use a method called a _set_ accessor.*/

            /* e. A class is like a engineering drawing of a car, and an object is someone who use that engineering drawing to build a car. which means a class is a definition, and an object is an executor.
             *    We can create an unlimited number of classes with different objects of each class.
             *    Example:
                    class1 = lab2()
                    class2 = lab2()
                    class3 = lab2()
                    */
        }
    }
}
