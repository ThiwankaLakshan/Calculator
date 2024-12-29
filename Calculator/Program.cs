using System;

namespace Calculator
{
    class Program
    {

        static void Main(string[] args)
        {
            int num1, num2, choice, result = 0;
            Console.WriteLine("Hello, welcome to the calulator program!");
            Console.WriteLine("Please enter your first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your choice:");
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.substraction");
            Console.WriteLine("3.Multifiction");
            Console.WriteLine("4.Division");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                result = num1 + num2;
            }
            else if (choice == 2)
            {
                result = num1 - num2;
            }
            else if (choice == 3)
            {
                result = num1 * num2;
            }
            else if (choice == 4)
            {
                result = num1 / num2;
            }
            else
            {
                Console.WriteLine("Enter the choice correctly!");
            }

            Console.WriteLine("Your Answer is: "+ result);
        }
    }
}