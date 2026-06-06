namespace loops2
{
    class Program
    {
        static void Main(string[] args)
        {

            // This is a while loop. It will continue to execute as long as the condition is true.

            int myValue = 0;
            int forLoopValue = 10;

            while (myValue < 10)
            {
                myValue++;
                Console.WriteLine($"WHILE LOOP  " + myValue);
            }

            // This is a for loop. It will execute a specific number of times, as defined by the initialization, condition, and increment/decrement.

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"FOR LOOP  " + forLoopValue);
                forLoopValue += 10;
            }


        }
    }
}
