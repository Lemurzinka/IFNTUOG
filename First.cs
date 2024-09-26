using System;

class First
{
    static void Main()
    {
       
        Console.WriteLine("Обчислення відстані між населеними пунктами.");
        Console.Write("Масштаб карти (кількість кілометрів в одному сантиметрі) -> ");
        double scale = Convert.ToDouble(Console.ReadLine());

        Console.Write("Відстань між точками, які позначають населені пункти (См) -> ");
        double distanceInCm = Convert.ToDouble(Console.ReadLine());

       
        double distanceInKm = scale * distanceInCm;

      
        Console.WriteLine($"Відстань між населеними пунктами {distanceInKm} км.");
    }
}
