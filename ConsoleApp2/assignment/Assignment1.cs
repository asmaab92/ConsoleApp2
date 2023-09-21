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
          Console.WriteLine(  Method1());

           String result2 = Method2();
            Console.WriteLine( result2 );

            String message = "Please enter your mothertongue";
          String result3 =  Method3(message);
            Console.WriteLine( result3 );

            String word = "season";
          String result4 =  Method4(word);
            Console.WriteLine(result4);

            String firstName = "Enter your first name please: ";
            String lastName = "Enter your last name please: ";
           String result5 = Method5(firstName,lastName);
            Console.WriteLine(result5);

        }

        public static String Method1()
        {
            Console.WriteLine("Please enter your name: ");
            String userName = Console.ReadLine();
            
            return userName;
        }

        public static String Method2()
        {
        Console.WriteLine("Write your favorite color: ");
        String favoriteColor = Console.ReadLine();
            
            return "#" + favoriteColor;
        }

        public static String Method3(String message) 
        {
            
            Console.WriteLine(message);
            String mothertongue = Console.ReadLine();
            
            return mothertongue;
        }

        public static String Method4(String word)
        {
            
            Console.WriteLine("Please write your favorite " + word);
            String text = Console.ReadLine();
            
            return text;
        }

        public static String Method5(String firstName,String lastName) 
        {
            Console.WriteLine("Enter your first name please: ");
             firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name please: ");

            lastName = Console.ReadLine();
            String nameFormate = lastName + ", " + firstName;
          
            return nameFormate;
        }
    }
}
