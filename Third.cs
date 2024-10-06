using System;


namespace gevkach
{
    internal class Third
    {
        static void Main() {
            int[] array = {1, 3, 5, 5, 3};

            Console.Write("Enter a number to search: ");
            int numberToSearch = int.Parse(Console.ReadLine());

            int calculatedAppears = CalculateNumberOfMeeting(numberToSearch, array);

            Console.Write($"The number {numberToSearch} appears {calculatedAppears} times in array");
            

        }

        static int CalculateNumberOfMeeting(int number, int[] array ) 
        {
            int counter = 0;
            foreach(int element in array){
                if (element == number) {
                    counter++;
                }
            }
            return counter;
        }
    }
}
