using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ConsoleApp2.assignment
{
    public class utilities
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");

           String userName = Console.ReadLine();

            Console.WriteLine(userName);

            Console.WriteLine("Enter your favorite color: ");
            String favoriteColor = Console.ReadLine();
            Console.WriteLine("#" + favoriteColor);

            String message = "Please enter your mothertongue: ";
            Console.WriteLine(message);
            String mothertongue = Console.ReadLine();
            Console.WriteLine(mothertongue);

            String word = "season";
            Console.WriteLine("Please enter a " + word);
            String text = Console.ReadLine();
            Console.WriteLine(text);

            String firstName = "Asmaa";
            String lastName = "Abualkheir";
            Console.WriteLine(lastName + ", " + firstName);

            Console.WriteLine("test");


            
        }
    }
}
