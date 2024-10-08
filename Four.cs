using System;

namespace gevkach
{
    internal class Four
    {
        static void Main()
        {
            Console.Write("Enter your letter: ");
            string input = Console.ReadLine();

            if (char.TryParse(input, out char result))
            {
                byte isVoWel = glasn(result);
                string answer = isVoWel == 1 ? "Yes" : "No";
                Console.WriteLine("Is your letter vowel?: " + answer);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a single character.");
            }
        }

        static byte glasn(char element)
        {
            char[] vowelLeters = { 'a', 'e', 'i', 'o', 'u' };
            element = char.ToLower(element);  

            foreach (char letter in vowelLeters)
            {
                if (letter == element)
                {
                    return 1;
                }
            }
            return 0;
        }
    }
}
