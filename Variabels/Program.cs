using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variabels
{
    class Program
    {
        static void Main(string[] args) // Deze is een methode
        {

          
            string firstName;
            string lastName;
            int age;
            int klas;


            // Console.WriteLine("Hello en Welcome "  + firstName);
            // Console.WriteLine("Hello {0} en Welcome {0} ", {firstName);

            Console.WriteLine("Enter your name please...");     // show to the user
            firstName = Console.ReadLine();                     //ask user for input

            Console.WriteLine("Enter your last name please...") ;
            lastName = Console.ReadLine();

            // Console.WriteLine($"Hello {firstName} {lastName} and Welcome"); //show to the user


            //this is concatenation

            Console.WriteLine("Enter your age please"); // Here gebruiken we convertion *******
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your class");
            klas = int.Parse($"you are {age} years old and you are in class {klas}");
            Console.WriteLine("this is the last line" + age +" " + klas);
            Console.ReadLine();

                               
            Console.WriteLine("Your full name is " + firstName + " " + lastName);
            Console.WriteLine($"You are {age} years old ");

            Console.ReadLine();





        }
    }
}
