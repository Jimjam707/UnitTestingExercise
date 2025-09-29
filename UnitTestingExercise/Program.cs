using System;

namespace UnitTestingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
        var calculator = new Calculator();
        calculator.Add(1,2,3);
        calculator.Subtract(1,2);
        calculator.Multiply(1,2);
        calculator.Divide(1,2);
        Console.WriteLine($"{calculator.Add(1, 2, 3)}");
        Console.WriteLine($"{calculator.Subtract(1, 2)}");
        Console.WriteLine($"{calculator.Multiply(1, 2)}");
        Console.WriteLine($"{calculator.Divide(1, 2)}");
        
        }
    }
}
