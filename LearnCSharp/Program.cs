using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Learning the fundamentals of C#
namespace Giraffe1 // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {   //Building a simple interaction where program will ask for user's name and say hi to them. 
            Console.Write("Enter your name: ");//Write is not going to a new line, WriteLine goes to a new line after printing the string.
            string name = Console.ReadLine(); //Storing user input into a variable.
            Console.WriteLine("Hello " + name); //Printing string and variable. 

            Console.ReadLine(); //lets us see our output, lets user input something

        }
    }
}