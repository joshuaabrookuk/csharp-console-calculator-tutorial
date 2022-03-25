using System;

namespace CalculatorTutorial
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\r");


            double num = 0;

            Console.Write("Type a number, and then press Enter: ");
            string numInput1 = "";
            numInput1 = Console.ReadLine();

            while (!double.TryParse(numInput1, out num))
            {
                Console.Write("This is not valid input. Please enter an integer value: ");
                numInput1 = Console.ReadLine();
            }


            Console.Write("Type another number, and then press Enter: ");
            string numInput2 = "";
            numInput2 = Console.ReadLine();

            while (!double.TryParse(numInput2, out num))
            {
                Console.Write("This is not valid input. Please enter an integer value: ");
                numInput2 = Console.ReadLine();
            }

            double num1 = Int32.Parse(numInput1);
            double num2 = Int32.Parse(numInput2);

            Console.WriteLine("Choose an operator from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Type the key of your chosen function, and then press Enter? ");

   

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    while (num2 == 0)
                    {
                        Console.WriteLine("Enter a non-zero divisor: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                    }
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
            }

            Console.Write("Press any key to close the Calculator console app");
            Console.ReadKey();
        }
    }
}
