using System;
class Program {
    static void Main(string[] args)
    {
        double result = 0;
        Console.WriteLine("         =====Simple Calculator=====         ");
        Console.WriteLine("---------------------------------------------");
        Console.Write("Enter first number: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Choose operation:\nA. +\nB. -\nC. *\nD. /\nE. %");
        Console.Write("Your choice: ");
        char op = char.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double num2 = double.Parse(Console.ReadLine());
        Console.WriteLine("---------------------------------------------");
        switch (op) 
        { 
            case 'A':
            case 'a':
            case '+':
                result = num1+num2;
                Console.WriteLine($"{num1} + {num2} = {result}");
                Console.WriteLine("---------------------------------------------");
                break;

            case 'B':
            case 'b':
            case '-':
                result = num1 - num2;
                Console.WriteLine($"{num1} - {num2} = {result}");
                Console.WriteLine("---------------------------------------------");
                break;

            case 'C':
            case 'c':
            case '*':
                result = num1 * num2;
                Console.WriteLine($"{num1} * {num2} = {result}");
                Console.WriteLine("---------------------------------------------");
                break;

            case 'D':
            case 'd':
            case '/':
                if (num2 == 0) { 
                Console.WriteLine("\nError: Cannot divide by zero!");
                Console.WriteLine("---------------------------------------------");
                }

                else { 
                result = num1 / num2;
                Console.WriteLine($"{num1} / {num2} = {result}");
                Console.WriteLine("---------------------------------------------");
                }
                break;

            case 'E':
            case 'e':
            case '%':
                result = num1 % num2;
                Console.WriteLine($"{num1} % {num2} = {result}");
                Console.WriteLine("---------------------------------------------");
                break;

            default:
                Console.WriteLine("Error: Invalid operator!");
                Console.WriteLine("---------------------------------------------");
                break;
        }


    }
}