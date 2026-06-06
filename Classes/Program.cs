using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Person class - this is called creating an object
            Person myPerson = new Person();
            myPerson.name = "John Doe";

            // Call the Eat method on the myPerson object
            myPerson.Eat(7);

            Console.WriteLine(myPerson.name); 
            Console.WriteLine(myPerson.weight);
            // Call the FirstInitial method and print the result
            Console.WriteLine(myPerson.FirstInitial());
        }

    }
}
