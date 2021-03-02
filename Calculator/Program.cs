using System;
using System.Globalization;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            if (DateTime.Now.Hour > 5 && DateTime.Now.Hour < 13)
            {
                Console.WriteLine("Good morning, and welcome to my calculator!");
            }
            else if (DateTime.Now.Hour > 13 && DateTime.Now.Hour < 18)
            {
                Console.WriteLine("Good afternoon, and welcome to my calculator!");
            }
            else
            {
                Console.WriteLine("Good night, and welcome to my calculator!");
            }

            int answer = 0;

            while (answer != 7)
            {
                Console.WriteLine("Please type the number according to the operation you want to do, as listed by the subtitles below:");

                Console.WriteLine();

                Console.WriteLine("1 = Sum");
                Console.WriteLine("2 - Subtraction");
                Console.WriteLine("3 - Multiplication");
                Console.WriteLine("4 - Division");
                Console.WriteLine("5 - Potentiation");
                Console.WriteLine("6 - Root");
                Console.WriteLine("7 - Leave calculator");
                Console.WriteLine();
                Console.Write("Your chosen operation is: ");


                answer = int.Parse(Console.ReadLine());

                if (answer != 7)
                {
                    Console.WriteLine("Please type the two numbers that you will operate, separated by a space each.");
                    string[] numbers = Console.ReadLine().Split(' ');
                    double a = double.Parse(numbers[0], CultureInfo.InvariantCulture);
                    double b = double.Parse(numbers[1], CultureInfo.InvariantCulture);

                    switch (answer)
                    {
                        case 1:
                            Console.WriteLine("Result = " + Calculator.Sum(a, b));
                            Console.WriteLine();
                            break;
                        case 2:
                            Console.WriteLine("Result = " + Calculator.Subtract(a, b));
                            Console.WriteLine();
                            break;
                        case 3:
                            Console.WriteLine("Result = " + Calculator.Multiply(a, b));
                            Console.WriteLine();
                            break;
                        case 4:
                            Console.WriteLine("Result = " + Calculator.Divide(a, b));
                            Console.WriteLine();
                            break;
                        case 5:
                            Console.WriteLine("Result = " + Calculator.Power(a, b));
                            Console.WriteLine();
                            break;
                        case 6:
                            Console.WriteLine("Result = " + Calculator.Root(a, b));
                            Console.WriteLine();
                            break;
                    }

                    Console.WriteLine("Would you like to do another operation? (Yes or No) ");
                    string answer2 = Console.ReadLine();

                    if (answer2 == "No")
                    {
                        answer = 7;
                    }
                }
            }
            Console.WriteLine("Thank you for using my calculator, bye!");
        }
    }
}
