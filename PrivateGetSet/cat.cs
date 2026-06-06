using System;
using System.Collections.Generic;
using System.Text;

namespace PrivateGetSet
{
    class Cat
    {
        // This is a private field that holds the name of the cat. It is not accessible from outside the class.
        private string name;

        private int age;

        // This is a constructor that takes a string parameter to initialize the name field of the cat class.
        public Cat(string newName, int newAge) 
        { 
            name = newName;
            age = newAge;
        }

        // This is a public property that allows external code to get and set the age of the cat. 
        public int Age
        {
            // The get accessor returns the value of the private age field, allowing external code to read the age of the cat.
            get { return age; }
            // The set accessor allows external code to assign a new value to the private age field, enabling the age of the cat to be updated.
            set { age = value; }
        }

        // This is a public method that returns the name of the cat. It allows external code to access the private name field.
        public string getName()
        {
            return name;
        }

        // This is a public method that allows external code to set the name of the cat.
        // It takes a string parameter and assigns it to the private name field.
        public void setName(string newName)
        {
            name = newName;
        }

    }
}
