using System;
using System.Collections.Generic;
using System.Text;

namespace PrivateGetSet
{
    class Program
    {
        // The Cat class with private get and set accessors
        static void Main(string[] args)
        {
            Cat myCat = new Cat("Whiskers", 6);
            myCat.setName("Abigail");

            myCat.Age = 7;

            // This will print "Abigail" to the console
            Console.WriteLine(myCat.getName());
            Console.WriteLine(myCat.Age);
        }
    }
}
