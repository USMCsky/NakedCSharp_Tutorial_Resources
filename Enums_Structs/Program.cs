using System;


namespace Enums_Structs
{
    enum Meal
    {
        Breakfast,
        Lunch,
        Dinner
    }


    class Program
    {
        static void Main(string[] args)
        {
            Meal mostImportantmeal = Meal.Breakfast;
            if (mostImportantmeal == Meal.Breakfast)
            {
                Console.WriteLine("Breakfast is the most important meal of the day.");
            }

            Console.WriteLine((Meal)0);
            Console.WriteLine(Meal.Dinner);
            Console.WriteLine((int)Meal.Lunch);
        }
    }
}
