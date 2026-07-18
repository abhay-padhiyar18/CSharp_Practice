
using System;

class Program
{
    static void Main()
    {
        //Program-1 simple Interest Calculation 

        //Console.Write("Enter Principal Amount:"); 
        //decimal principal = Convert.ToDecimal(Console.ReadLine()); 
        //Console.Write("Enter Rate of Interest:"); 
        //decimal rate = Convert.ToDecimal(Console.ReadLine()); 
        //Console.Write("Enter Time (in years):"); 
        //int time = Convert.ToInt32(Console.ReadLine()); 

        //decimal simpleInterest = (principal * rate * time) / 100; 
        //Console.WriteLine("Simple Interest: {0}", simpleInterest); 


        //Program 2 temperature conversion

        //Console.Write("Enter Temperature in Celsius:");
        //double celsius = Convert.ToDouble(Console.ReadLine());

        //double fahrenheit = (celsius * 9 / 5) + 32;

        //Console.WriteLine("Temperature in Celsius: " + celsius);
        //Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);



        //Program 3 Swapping two numbers

        //Console.Write("Enter First Number:");
        //int num1 = Convert.ToInt32(Console.ReadLine());

        //Console.Write("Enter Second Number:");
        //int num2 = Convert.ToInt32(Console.ReadLine());


        //Console.WriteLine("Before Swapping:");
        //Console.WriteLine("First Number: " + num1);
        //Console.WriteLine("Second Number: " + num2); 

        //// Swapping using a temporary variable
        //int temp = num1;
        //num1 = num2;
        //num2 = temp;

        //Console.WriteLine("After swapping:");
        //Console.WriteLine("First Number: " + num1);
        //Console.WriteLine("Second Number: " + num2);


        //Program 4 BMI

        Console.Write("Enter Weight (in kg): ");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Height (in meters): ");
        double height = Convert.ToDouble(Console.ReadLine());
        if (height <= 0)
        {
            Console.WriteLine("Height must be greater than zero.");
            return;
        }

        

        double bmi = weight / (height * height);


        Console.WriteLine("Weight: " + weight);
        Console.WriteLine("Height: " + height);

        Console.WriteLine("BMI: " + bmi.ToString("F2"));

        if (bmi < 18.5) {
            Console.WriteLine("You are underweight.");
        }
        else if (bmi >= 18.5 && bmi < 25) {
            Console.WriteLine("You have a normal weight.");
        }
        else if (bmi >= 25 && bmi < 30) {
            Console.WriteLine("You are overweight.");
        }
        else {
            Console.WriteLine("You are obese.");
        }
    }
}
