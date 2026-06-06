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
            Person myPerson = new Person("Nancy", 120);
            Person myOtherPerson = new Person("Richard");

            // Call the Eat method on the myPerson object and the myOtherPerson object
            myPerson.Eat(10);
            myOtherPerson.Eat(20);


            Console.WriteLine("The species of both people is: " + Person.species + " " + Person.personCount);
            Console.WriteLine(myPerson.name +" " + myPerson.weight + " " +myPerson.FirstInitial());
            Console.WriteLine(myOtherPerson.name + " " + myOtherPerson.weight + " " + myOtherPerson.FirstInitial());
        }

    }
}
