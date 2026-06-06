using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    // A class is a blueprint for creating objects. It defines the properties and behaviors of the objects that will be created from it.
    class Person
    {
        // Fields - these are the properties of the class- they are variables that belong to the class
        public string name = "Bob";
        public int weight = 200;

        // Static field- this is a property that belongs to the class itself, it is shared among all instances of the class.
        public static string species = "Human";
        public static int personCount = 0;

        // This is a constructor- it is a special method that is called when an object is created from the class.
        // It is used to initialize the properties of the object.
        // overloading the constructor- we can have multiple constructors with different parameters to allow for different ways of creating an object
        public Person(string newName)
        {
            name = newName;
            personCount++;
        }

        public Person(string newName, int newWeight) 
        {
            name = newName;
            weight = newWeight;
            personCount++;
        }


        // Methods - these are the behaviors of the class- they are functions that belong to the class
        public void Eat(int val) 
        {
            weight += val;      // When the Eat method is called, it will increase the weight of the person by the value passed in as an argument
         }

        public char FirstInitial()
        {
            return name[0];     // This method returns the first character of the person's name
        }

    }
}
