namespace Switch_statment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myValue = 13;
            string myMessage = "Hello World";
            //
            switch (myValue)
            {
                case 1:
                    myMessage = "The value is 1";
                    break;
                case 2:
                    myMessage = "The value is 2";
                    break;
                case 3:
                    myMessage = "The value is 3";
                    break;
                default:
                    myMessage = "The value is something else";
                    break;
            }

            Console.WriteLine(myMessage);
        }
    }
}
