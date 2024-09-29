using System;

class Second
{
    static void Main()
    {
        
        Console.Write("Введiть рiк, наприклад 2000, -> ");
        int year = Convert.ToInt32(Console.ReadLine());

        
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine($"{year} рiк - високосний");
        }
        else
        {
            Console.WriteLine($"{year} рiк - не високосний");
        }
    }
}
