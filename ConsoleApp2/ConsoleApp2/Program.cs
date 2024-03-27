using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-----------------------\r\n*  Simple Calculator  *\r\n-----------------------");
        // Prompt the user to enter two numbers
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Prompt the user to choose an operation
        Console.WriteLine("\nChoose an operation:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");

        Console.Write("\nEnter the operation number (1-4): ");
        int operation = Convert.ToInt32(Console.ReadLine());

        double result = 0;

        // Perform the selected operation
        switch (operation)
        {
            case 1:
                result = num1 + num2;
                Console.WriteLine($"\nResult of Addition: {result}");
                break;
            case 2:
                result = num1 - num2;
                Console.WriteLine($"\nResult of Subtraction: {result}");
                break;
            case 3:
                result = num1 * num2;
                Console.WriteLine($"\nResult of Multiplication: {result}");
                break;
            case 4:
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine($"\nResult of Division: {result}");
                }
                else
                {
                    Console.WriteLine("\nError: Division by zero is not allowed.");
                }
                break;
            default:
                Console.WriteLine("\nInvalid operation number. Please choose a number between 1 and 4.");
                break;
        }

        Console.ReadLine(); // Keep console window open
    }
}
