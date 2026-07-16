using System;

class Employee
{
    //const double PI = 3.14159;

    public readonly DateTime JoiningDate = DateTime.Now;
}
class Program
{
    static void Main()
    {
        Employee emp = new Employee();
        Console.WriteLine(emp.JoiningDate);
        //Console.WriteLine(PI);
    }
}
