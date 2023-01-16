using System.Security.Cryptography;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            double doubInput;
            double doubInput2;

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();



            Console.SetCursorPosition(44, 2);
            Console.WriteLine("THE CELSIUS TO FAHRENHEIT CONVERTERINATOR!");
            Console.SetCursorPosition(45, 10);
            Console.WriteLine("How warm is it in celsius?");
            Console.SetCursorPosition(45, 12);
            Console.Write("Celsius:");
            string input = Console.ReadLine();
            bool isString = double.TryParse(input, out doubInput);
            Console.SetCursorPosition(45, 15);
            Console.WriteLine($"It is {CelToFar(doubInput)} degrees in fahrenheit \n");
            Console.SetCursorPosition(45, 17);
            Console.WriteLine("Press a button to clear and close the program:");
            Console.ReadKey();
            Console.Clear();


        }

    static double CelToFar(double celsius)
    {
        return ((float)celsius * 1.8 + 32);

    }
}
}