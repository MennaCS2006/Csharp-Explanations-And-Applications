using System;
class Program {
    static void Main(string[] args)
    {
        double result = 0;
        bool ValidOp = true;
        Console.WriteLine("         =====Simple Calculator=====         ");
        Console.WriteLine("---------------------------------------------");
        Console.Write("Enter first number: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter an operator (+, -, *, /, %) ");
        Console.Write("Your choice: ");
        char op = char.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double num2 = double.Parse(Console.ReadLine());
        Console.WriteLine("---------------------------------------------");
        switch (op) 
        { 
           
            case '+':
                result = num1+num2;
                break;

            
            case '-':
                result = num1 - num2;
                break;

            
            case '*':
                result = num1 * num2;
                break;

            
            case '/':
                if (num2 == 0) { 
                Console.WriteLine("\nError: Cannot divide by zero!");
                Console.WriteLine("---------------------------------------------");
                    ValidOp = false;
                }

                else { 
                result = num1 / num2;
                     }
                break;

           
            case '%':
                result = num1 % num2;
                 break;

            default:
                ValidOp = false;
                Console.WriteLine("Error: Invalid operator!");
                Console.WriteLine("---------------------------------------------");
                break;
        }
        if (ValidOp == true) 
        {

            Console.WriteLine($"{num1} {op} {num2} = {result}");
            Console.WriteLine("---------------------------------------------");
            if (result % 2 == 0 && result>0)
            {
                Console.WriteLine($"{result} is even and positive");
                Console.WriteLine("---------------------------------------------");
            }
            else if (result % 2 == 1 && result > 0)
            {
                Console.WriteLine($"{result} is odd and positive");
                Console.WriteLine("---------------------------------------------");
            }
            else if (result % 2 == 0 && result < 0)
            {
                Console.WriteLine($"{result} is even and negative");
                Console.WriteLine("---------------------------------------------");
            }
            else if (result % 2 == 1 && result < 0)
            {
                Console.WriteLine($"{result} is odd and negative");
                Console.WriteLine("---------------------------------------------");
            }
            else
            {
                Console.WriteLine($"{result} is Zero");
                Console.WriteLine("---------------------------------------------");
            }

        }



    }
}