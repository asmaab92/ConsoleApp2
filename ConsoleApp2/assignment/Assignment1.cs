using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.assignment
{
    internal class Assignment1
    {
        public static void Main(string[] args)
        {
            Method1();
            Method2();
            Method3();
            Method4();
            Method5();

        }

        public static String Method1()
        {
            Console.WriteLine("Please enter your name: ");
            String userName = Console.ReadLine();
            Console.WriteLine(userName);
            return userName;
        }

        public static String Method2()
        {
        Console.WriteLine("Write your favorite color: ");
        String favoriteColor = Console.ReadLine();
            Console.WriteLine("#" + favoriteColor);
            return favoriteColor;
        }

        public static String Method3() 
        {
            String message = "Please enter your mothertongue";
            Console.WriteLine(message);
            String mothertongue = Console.ReadLine();
            Console.WriteLine(mothertongue);
            return mothertongue;
        }

        public static String Method4()
        {
            String word = "season";
            Console.WriteLine("Please write your favorite " + word);
            String text = Console.ReadLine();
            Console.WriteLine(text);
            return text;
        }

        public static String Method5() 
        {
        Console.WriteLine("Enter your first name ");
            String firstName = Console.ReadLine();
        Console.WriteLine("Enter your last name ");
            String lastName = Console.ReadLine();
            String nameFormate = lastName + ", " + firstName;
            Console.WriteLine(nameFormate);
            return nameFormate;
        }
    }
}
