using System;

class Six
{
    delegate double DivisionDelegate(double a, double b);

    static void Main()
    {
        DivisionDelegate divide = delegate (double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Division by zero is not allowed.");
                return double.NaN; 
            }
            return a / b;
        };

        double result = divide(10, 2);
        Console.WriteLine($"Result: {result}");

        result = divide(10, 0);
        Console.WriteLine($"Result: {result}");
    }
}
