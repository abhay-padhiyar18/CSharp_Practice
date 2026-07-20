using System;

class Program
{
    static void Main()
    {
        // Program 1 : simple  calculator suing operatoe only




        //Console.Write("Enter first number: ");
        //int num1 = Convert.ToInt32(Console.ReadLine());
        //Console.Write("Enter second number: ");
        //int num2 = Convert.ToInt32(Console.ReadLine());


        //Console.WriteLine("Addition: " + (num1 + num2));
        //Console.WriteLine("Subtraction: " + (num1 - num2));
        //Console.WriteLine("Multiplication: " + (num1 * num2));
        //Console.WriteLine("Division: " + (num1 / num2));
        //Console.WriteLine("Modulus: " + (num1 % num2));




        //Program 2: odd or even number using operator

        //Console.Write("Enter a number: ");

        //int number = Convert.ToInt32(Console.ReadLine());


        //if (number % 2 == 0)
        //{
        //    Console.WriteLine("The number is even.");
        //}
        //else
        //{
        //    Console.WriteLine("The number is odd.");
        //}

        //Progrma 3  which is the largest number using operator

        //Console.Write("Enter first number: ");
        //int num1 = Convert.ToInt32(Console.ReadLine());

        //Console.Write("Enter Second Number: ");
        //int num2 = Convert.ToInt32(Console.ReadLine());

        //if (num1 > num2)
        //{
        //    Console.WriteLine("The largest number is: " + num1);
        //}
        //else if (num1 < num2)
        //{
        //    Console.WriteLine("The largest number is: " + num2);
        //}
        //else
        //{
        //    Console.WriteLine("Both numbers are equal.");
        //}


        //Program 4 three largest number using operator

        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Second Number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Third Number: ");
        int num3 = Convert.ToInt32(Console.ReadLine());

        if (num1 == num2 && num2 == num3)
        {
            Console.WriteLine("All numbers are equal.");
        }
        else if (num1 >= num2 && num1 >= num3)
        {
            Console.WriteLine("The largest number is: " + num1);
        }
        else if (num2 >= num1 && num2 >= num3)
        {
            Console.WriteLine("The largest number is: " + num2);
        }
        else
        {
            Console.WriteLine("The largest number is: " + num3);
        }









    }
}
