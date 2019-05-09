using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    class Program
    {
        static void Main(string[] args)
        {
            {//1
                /*class Book 
                    {
                        public string Title { get; set; }
                        public string Year { get; set; }
                        public string Author { get; internal set; }

                        internal void Display()
                        {
                            Console.WriteLine("About the Book");
                            Console.WriteLine();
                            Console.Write("Title:  ");
                            Console.WriteLine(Title);
                            Console.Write("Author: ");
                            Console.WriteLine(Author);
                            Console.Write("Year:   ");
                            Console.WriteLine(Year);
                        }

                    }*/

                /*class Program
                    {
                        static void Main(string[] args)
                        {
                            Book mybook = new Book();
                            mybook.Title = "Visual C#: How to Program(5th Edition)";
                            mybook.Author = "Harvey Deitel and Paul Deitel ";
                            mybook.Year = "2012";

                            mybook.Display();

                            Console.ReadKey();
                        }
                    }*/
            }

            {//2
                /*static void Main(string[] args)
                    {
                        Book book = new BookTest
                        {
                            BookTitle = "Visual C#: How to Program(5th Edition)",
                            BookAuthor = "Harvey Deitel and Paul Deitel",
                            BookYear = "2012",
                        };
                    }*/
            }

            {//3
                //Create an instance of Book class with the 'new' keyword in the main activity and then call those methods on that object.
            }

            {//4
                //Sometimes in a class will have multi constructors. We usually use "this" to have one constructor invocation call another constructor method. It reduces code bloat and makes code easier to read and understand. Moreover, the this-keyword allows code to be shared between the constructors. Constructor initializers are useful in nontrivial classes.
            }

            {//5
                //Exception handling is also called error handling in C#, used to prevent the program from being stuck due to unusual occurrences. If the exceptions are handled properly, the program will never get suddenly terminated.
            }

            {//6
                //Public constructors allow a class to be instantiated from an external location in the program. Most of the constructors will be in the public accessibility domain. In other words, Public constructors are used to create class instances from outside the class.

                //Private constructors are not able to be called externally. However, it ensures a higher-quality code. It makes the class provide a controlled and unified access pattern. In other words, the Private constructor makes it impossible for external code to instantiate the class easily without using reflection.
            }

            {//7
                /*The composition is a special type of Aggregation and gives is-a-part-of or has-a relationship. 
                  For example, HOWTOCODE is a Book. So,

                        class Book
                        {
                        }

                        class HOWTOCODE : Book
                        {
                        }

                  Whereas, Composition denotes "is-a-part-of" or “has-a” relationship between objects. 
                  For example,

                        class HOWTOCODE
                        {
                        }

                        class Book
                        {
                            HOWTOCODE howtocode = new HOWTOCODE();
                        }
                 
                 To sum up, Composition is a design technique to implement is-a-part-of or has-a relationship in classes, either by Inheritance or object Composition for code reuse.
                 */
            }

            {//8
                //Data abstraction is one of the principles of object-oriented programming. It is declared with the help of the abstract keyword. Data abstraction is a simplified representation that simplifies a particular data body into a whole.
            }
        }
    }
}

