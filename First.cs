using System;

class First
{
    static void Main()
    {
       
        Console.WriteLine("Обчислення вiдстанi мiж населеними пунктами.");
        Console.Write("Масштаб карти (кiлькiсть кiлометрiв в одному сантиметрi) -> ");
        double scale = Convert.ToDouble(Console.ReadLine());

        Console.Write("Вiдстань мiж точками, якi позначають населенi пункти (См) -> ");
        double distanceInCm = Convert.ToDouble(Console.ReadLine());

       
        double distanceInKm = scale * distanceInCm;

      
        Console.WriteLine($"Вiдстань мiж населеними пунктами {distanceInKm} км.");
    }
}

