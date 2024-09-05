using System;

namespace Calculator
{
    class Program
    static void Main(string[] args)
    {
        int num1;
        int num2;
        int result;
        string answer;

        Console.WriteLine("Beginning of the calculated era.");
        Console.WriteLine("__________________________________\n")

        Console.WriteLine("Enter your first number then press Enter.");
        num1 = (int)Console.ReadLine();
        Console.WriteLine($"You have entered {num1}.");

        Console.WriteLine("Enter your second number then press Enter.");
        num2 = (int)Console.ReadLine();
        Console.WriteLine($"You have entered {num2}.");

        Console.WriteLine("Choose an option from the following list:");
        Console.WriteLine("\ta - Add");
        Console.WriteLine("\ts - Subtract");
        Console.WriteLine("\tm - Multiply");
        Console.WriteLine("\td - Divide\n");
        Console.WriteLine("Type your selection then press enter.");

        answer = Console.ReadLine();

        if (answer == "a")
        {
            sum = num1 + num2;
            result = $"{num1} + {num2} = {sum}";
        }
        else if (answer == "s")
        {
            difference = num1 - num2;
            result = $"{num1} - {num2} = {difference}";
        }
        else if (answer == "m")
        {
            product = num1 * num2;
            result = $"{num1} * {num2} = {product}";
        }
        else (answer == "d")
        {
            quotient = num1 / num2;
            result = $"{num1} / {num2} = {quotient}";
        }

        Console.WriteLine($"The result is: {result}.\n");
        Console.WriteLine("End of calculated era.");
        Console.WriteLine("________________________\n");
        Console.WriteLine("Press any key to terminate the program.)

        Console.ReadKey();
    }
}