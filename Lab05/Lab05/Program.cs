using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    class Program
    {
        static void Main(string[] args)
        {
            {//2
                //a. Scope - Decides whether the method is public or private, and the Public is the scope of this example.
                //b. Static vs. Non-Static - There is no static showed behind the Public in this example, so this example is the Non-Static method.
                //c. Return Type - A return type means the data type of the value returned from a subroutine or method. The return is the return type in this example.
                //d. Method Name (Identifier) - It is the unique name of the method, in the example it is "getArea".
                //e. Parameters - They are the parameters inside of the(), so they are "double height, double width" in this example.
                //f. Method Body -  It is a set of instructions, the "height * width" is the Method Body in this example.
            }

            {//3
                /*the user-defined method is created by the user/developer, and it is hidden from other methods. The method that is provided with a framework is able to be reused. One thing we should consider about when creating a user-defined method, 
                that is to make sure what we are going to create can work perfectly and correctly, and just not to create a method that can not be run.*/
            }

            {//4
                //The difference between a Static and Non-Static method is that the Static method is not accessible to any of the objects non-static fields, but a non-static method is allowed to access all the non-static fields in an object.
            }

            {//5
                // below is the code for the Dog.cs
                // public void bark(){ Console.WriteLine("{0} is Barking...", Name);
                // and myDog.bark(); for the Program.cs
            }

            {//6
             // below is the code for the Dog.cs
             // public void doTrick(string trickName)
             // { Console.WriteLine("{0} is so smart! {0} is doing a(n) {1}", Name, trickName); }
             // and myDog.doTrick("Fetch"); for the Program.cs
             
                //the screenshots of the code were sent to your e-mail, again thank you for helping.
            }
        }
    }
}
