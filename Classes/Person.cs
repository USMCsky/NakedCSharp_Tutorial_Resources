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
        public int weight = 150;

        // Methods - these are the behaviors of the class- they are functions that belong to the class
        public void Eat(int val) 
        {
            // When the Eat method is called, it will increase the weight of the person by the value passed in as an argument
            weight += val;
         }
        // This method returns the name of the person
        public char FirstInitial()
        {
            // This method returns the first character of the person's name
            return name[0];
        }

    }
}
