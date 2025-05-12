using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_o5_0._2
{
    internal class Program
    {
        List<string> my_list = new List<string> ();

        static void getAge()
        {
            int currentYear = 2025;
            Console.Write("enter year of birth: ");
            int yearOfBirth = int.Parse(Console.ReadLine());
            Console.WriteLine($"your age  is {currentYear - yearOfBirth}");
        }
        static void getName()
        {
            Console.Write("what is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine($"hello {name}");
        }

        static void randomNumber()
        {
            Random r = new Random();
            Console.WriteLine(r.Next());
        }

        static List<string> enter(string name)
        {
            my_list.Add(name);
            return my_list;
        }

        //static List<string> exit(string name);
        //{
            
        //}

        static void Main(string[] args)
        {
            //    Console.WriteLine("\"Please choose from the menu:\\n\" +\r\n " +
            //        "                 \"1 - We'll tell you what your age is\\n\" +\r\n " +
            //        "                 \"2 - We'll greet you\\n\" +\r\n " +
            //        "                 \"3 - We'll give you a random number\";");
            //    int menu = int.Parse(Console.ReadLine());
            //    switch (menu)
            //    {
            //        case 1:
            //            getAge();
            //            break;
            //        case 2:
            //            getName();
            //            break;
            //        case 3:
            //            randomNumber();
            //            break;

            //    }

            List<string> my_list = new List<string>();


        }
    }
}