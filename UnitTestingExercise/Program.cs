using System;

namespace UnitTestingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();

            // Testing Add method
            int addResult = calculator.Add(2, 3, 5);
            Console.WriteLine($"Add(2, 3, 5) = {addResult}"); // Expected: 10

            // Testing Subtract method
            int subtractResult = calculator.Subtract(10, 5);
            Console.WriteLine($"Subtract(10, 5) = {subtractResult}"); // Expected: 5

            // Testing Multiply method
            int multiplyResult = calculator.Multiply(2, 3);
            Console.WriteLine($"Multiply(2, 3) = {multiplyResult}"); // Expected: 6

            // Testing Divide method
            int divideResult = calculator.Divide(10, 2);
            Console.WriteLine($"Divide(10, 2) = {divideResult}"); // Expected: 5

            // Testing Divide by zero
            try
            {
                calculator.Divide(10, 0);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Divide(10, 0) = Exception: {ex.Message}"); // Expected: Exception
            }
        }
    }
}