using System;

    class Program
{

    static void Main()
    {

        //Program-1


        //Console.WriteLine("-----Student Information-----");

        //Console.Write("Enter Name:");
        //string name = Console.ReadLine();

        //Console.Write("Enter Age:");
        //int age = Convert.ToInt32(Console.ReadLine());

        //Console.Write("Enter Percentage:");
        //double percentage = Convert.ToDouble(Console.ReadLine());


        //Console.WriteLine();
        //Console.WriteLine("-----Student Details-----");
        //Console.WriteLine("Name : " + name);
        //Console.WriteLine("Age : " + age);
        //Console.WriteLine("Percentage : " + percentage);


        //Program_2

        //Console.Write("Enter Employee Name:");
        //string empName = Console.ReadLine();

        //Console.Write("Employee Monthly Salary:");
        //decimal empSalary = Convert.ToDecimal(Console.ReadLine());

        //decimal empAnnualSalary = empSalary * 12;




        //Console.WriteLine("------Employee Details------");
        //Console.WriteLine("Name: " + empName);
        //Console.WriteLine("Monthly Salary: " + empSalary);
        //Console.WriteLine("Annual Salary: " + empAnnualSalary);


        //Program-3

        //Console.Write("Enter Length of Rectangle:");
        //double length = Convert.ToDouble(Console.ReadLine());



        //Console.Write("Enter Width of Rectangle:");
        //double width = Convert.ToDouble(Console.ReadLine());

        //double area = length * width;


        //Console.WriteLine("Area of Rectangle: " + area);



        Console.Write("Enter Student Name:");
        string studentName = Console.ReadLine();

        Console.Write("Enter Subject 1 Marks:");
        int subject1Marks = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Subject 2 Marks:");
        int subject2Marks = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Subject 3 Marks:");
        int subject3Marks = Convert.ToInt32(Console.ReadLine());


        int totalMarks = subject1Marks + subject2Marks + subject3Marks;

        double averageMarks = totalMarks / 3.0;


        Console.WriteLine("Student Name: " + studentName);
        Console.WriteLine("Subject 1 Marks: " + subject1Marks);
        Console.WriteLine("Subject 2 Marks: " + subject2Marks);
        Console.WriteLine("Subject 3 Marks: " + subject3Marks);


        Console.WriteLine("Total Marks: " + totalMarks);
        Console.WriteLine("Average Marks: " + averageMarks);


    }
}