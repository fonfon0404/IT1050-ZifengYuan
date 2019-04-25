using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    class Program
    {
        static void Main(string[] args)
        {
            {//2
                //A one-dimensional array p contains four elements.The array access expressions to access each of the elements in p are __[0]__, __[1]__,__[2]__ and __[3]__.
            }

            {//3
                int[] number = new int[12];
                Console.WriteLine("{0}{1,15}", "Index", "Month");
                for (int counter = 0; counter < number.Length; counter++)
                {
                    string[] month = new string[12];
                    month[0] = "January";
                    month[1] = "February";
                    month[2] = "March";
                    month[3] = "April";
                    month[4] = "May";
                    month[5] = "June";
                    month[6] = "July";
                    month[7] = "August";
                    month[8] = "September";
                    month[9] = "October";
                    month[10] = "November";
                    month[11] = "December";
                    string m = month[counter];
                    Console.WriteLine("{0}{1,20}", counter, m); 

                }
            }

            {//4
                string[] seasons = { "Winter", "Spring", "Summer", "Fall" };
                Console.WriteLine("Four season names");
                foreach(string s in seasons)
                { Console.WriteLine(s); }
            }

            {//5
                Random random = new Random();
                int[] randomNumber = new int[1000];
                for (int n = 0; n < randomNumber.Length; n++)
                {
                    randomNumber[n] = random.Next(0, 100);
                }
                foreach(int n in randomNumber)
                {
                    Console.WriteLine(n);
                }
            }

            {//6
                string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

                int i = 0;
                while (i < names.Length)
                {
                    Console.WriteLine(names[i]);//modification #1
                    i++;//modification #2
                }

            }

            {//7
                string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

                int i = 0;
                while (i < names.Length)
                {
                    Console.WriteLine("{0,2}. {1}", i, names[i]);
                    i++;
                }
            }

            {//8
                string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

                int i = 0;
                foreach (string name in names)
                {
                    Console.WriteLine("{0,2}. {1}", i, names[i]);
                    i++;
                }
            }

            Console.ReadKey();
        }
    }
}
