using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Giraffe1 // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {   //Learning about variables and datatypes
            string characterName = "Tom";
            int characterAge;
            characterAge = 25;

            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");
            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge);

            string phrase = "Giraffe Academy";
            //Substring (a, b) a is the first index of the character we want, b is the number of characters we want to take after a.
            Console.WriteLine(phrase.Substring(phrase.IndexOf("Academy")));

            Console.ReadLine();

        }
    }
}