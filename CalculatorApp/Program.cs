// Include the System namespace for use of classes and methods such as Console
using System;

// Defines a class named Program which contains the Main method
class Program
{
    // static shows that Main belongs to itself
    // void specifies that Main does not return any value
    // Main is the entry point of a C# console application
    // When running a C# program, the execution starts from the Main method
    static void Main()
    {
        // Initialize the result variable; this will store the end result of the calculations
        int result = 0;
        // Initialize the answer variable; this will store the users choice of mathematical operation
        string answer;

        // Print a welcome message to the user upon starting the program
        Console.WriteLine("Beginning of the calculated era.");
        Console.WriteLine("__________________________________\n");

        // Prompt the user to enter the first number of the arithmetic
        Console.WriteLine("Enter your first number then press Enter.");

        // Stores user input as in a variable, stores an empty string if no input to prevent null
        string input1 = Console.ReadLine() ?? string.Empty;

        // Try to parse the input as an integer
        // 1st param input1 is the string that is being converted
        // 2nd param 'int num1' is the value to be returned
        // 'out' is a keyword that specifies that this is an output 
        if (int.TryParse(input1, out int num1))
        {
            // If succesful, print input to console
            Console.WriteLine($"You entered: {num1}.\n");
        }
        else
        {
            // If unable to parse as an int, display error message and exit program
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return; // exits the program
        }

        Console.WriteLine("Enter your second number then press Enter.");
        string input2 = Console.ReadLine() ?? string.Empty;
        if (int.TryParse(input2, out int num2))
        {
            Console.WriteLine($"You entered: {num2}.\n");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return;
        }

        // Provide options for the user to choose an arithmetic operation
        Console.WriteLine("Choose an option from the following list:");
        Console.WriteLine("\ta - Add");
        Console.WriteLine("\ts - Subtract");
        Console.WriteLine("\tm - Multiply");
        Console.WriteLine("\td - Divide\n");
        Console.WriteLine("Type your selection then press enter.");

        // Read input for choice of operation
        answer = Console.ReadLine() ?? string.Empty;

        // Perform arithmetic operation dependant on user input and operation choice
        switch (answer)
        {
            // Addition
            case "a":
                result = num1 + num2;
                Console.WriteLine($"\n{num1} + {num2} = {result}\n");
                break;

            // Subtraction
            case "s":
                result = num1 - num2;
                Console.WriteLine($"\n{num1} - {num2} = {result}\n");
                break;

            // Multiplication
            case "m":
                result = num1 * num2;
                Console.WriteLine($"\n{num1} * {num2} = {result}\n");
                break;

            // Division
            case "d":
                // Set failsafe if user tries to divide by zero
                if (num2 != 0)
                {
                    //Perform operation if divisor is not zero
                    result = num1 / num2;
                    Console.WriteLine($"\n{num1} / {num2} = {result}\n");
                }
                else
                {
                    //Error handling for user selecting divisor of zero
                    Console.WriteLine("\nStop trying to tear reality.\n");
                }
                break;

            default:
                // Handle invalid choice for operation
                Console.WriteLine("\nInvalid option selected.");
                break;
        }

        // Print final result
        Console.WriteLine($"The result is: {result}.\n");
        // Display closing message
        Console.WriteLine("End of calculated era.");
        Console.WriteLine("________________________\n");
        // Prompt the user to terminate the program
        Console.WriteLine("Press any key to terminate the program.");

        // Wait for user to press a key to prevent premature closing of program
        Console.ReadKey();
    }
}