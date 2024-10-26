using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scientificCalcu
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select operation:");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Square root");
            Console.WriteLine("6. Exponentiation");
            Console.WriteLine("7. Sin");
            Console.WriteLine("8. Cos");
            Console.WriteLine("9. Tan");

            Console.Write("Enter choice (1-9): ");
            string choice = Console.ReadLine();

            double num1, num2;

            if (choice != "5" && choice != "7" && choice != "8" && choice != "9")
            {
                Console.Write("Enter first number: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter second number: ");
                num2 = Convert.ToDouble(Console.ReadLine());
            }
            else
            {
                Console.Write("Enter number: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                num2 = 0;
            }

            switch (choice)
            {

                case "1":
                    Console.WriteLine($"Result: {Add(num1, num2)}");
                    break;
                case "2":
                    Console.WriteLine($"Result: {Subtract(num1, num2)}");
                    break;
                case "3":
                    Console.WriteLine($"Result: {Multiply(num1, num2)}");
                    break;
                case "4":
                    if (num2 == 0)
                    { 
                        Console.WriteLine("Error! Division by zero.");
                    }
                    else
                    {
                        Console.WriteLine($"Result: {Divide(num1, num2)}");
                    }
                    break;
            case "5":
                Console.WriteLine($"Result: {SquareRoot(num1)}");
                break;
            case "6":
                Console.WriteLine("Result: {Exponentiation(numi, num2)}");
                break;
            case "7":
                Console.WriteLine($"Result: {Math.Sin(DegreeToRadian(num1))}");
                break;
            case "8":
                Console.WriteLine($"Result: {Math.Cos(DegreeToRadian(num1))}3");
                break;
            case "9":
                Console.WriteLine($"Result: { Math.Tan(DegreeToRadian(num1))}"); 
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
        }
    }

        static double Add(double x, double y) => x + y;

        static double Subtract(double x, double y) => x - y;

        static double Multiply(double x, double y) => x * y;

        static double Divide(double x, double y) => x / y;

        static double SquareRoot(double x) => Math.Sqrt(x);

        static double Exponentiation(double x, double y) => Math.Pow(x, y);

        static double DegreeToRadian(double degree) => degree * (Math.PI / 180);
        
    }
}