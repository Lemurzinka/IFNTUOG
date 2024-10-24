using System;
using System.Collections.Generic;
using System.IO;

class Seven
{
    static void Main()
    {
        string directoryPath = Directory.GetCurrentDirectory(); //ну або його можемо і вказати :)
        Stack<string> directoryStack = new Stack<string>();

        try
        {
            foreach (var file in Directory.GetFiles(directoryPath))
            {
                directoryStack.Push(file);
            }

            foreach (var dir in Directory.GetDirectories(directoryPath))
            {
                directoryStack.Push(dir);
            }

            Console.WriteLine("Elements in stack:");
            while (directoryStack.Count > 0)
            {
                Console.WriteLine(directoryStack.Pop());
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
