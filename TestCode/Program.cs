using System;

namespace TestCode
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World!");
            //ascii table
            char myChar = 'A';
            int asciiA = (int)myChar; //casting char to int to get the
            Console.WriteLine("The ascii value of {0} is {1}\n", myChar, asciiA);

            int charNumber = 'z';
            Console.WriteLine("The ascii value of {0} \n", charNumber);

            string s = "The Quick Fox";
            s = s + " Jumps Over The Lazy Dog"; //string concatenation

            Console.WriteLine("{0,-10} {1,10}", "Left", "Right");

            int total = 0;
            int i = 2;
            while (i < 9)
            {
                total += 2;
                i++;
            }
            Console.WriteLine("The total is: {0}", total);

            int totalDo = 10;
            int x = 2;
            do
            {
                totalDo += 3;
                x += 1;
            } while (x < 3);
            Console.WriteLine("The total using do-while is: {0}", totalDo);


            for (int h = 0; h < 2; h++)
            {
                for (int j = 1; j < 3; j++)
                {
                    Console.WriteLine(h * j);
                }
            }

            for (int z = 0; z < 10; z++)
            {
                for (int p = 1; p < 2; p++)
                {
                    Console.WriteLine(z + p);
                }
            }

            int t = 0;
            while (t < 5)
            {
                Console.WriteLine("Hi");
                t++;
            }

            int c = 10;
            do
            {
                Console.WriteLine(c);
                c -= 3;
            }
            while (c > -4);


            string filePath = @"C:\Users\ezabi\source\repos\NakedCSharp\TypesDiagram.pdf";
            string fileName = System.IO.Path.GetFileName(filePath);
            Console.WriteLine($"The file name is: {fileName}");
        }
    }
}