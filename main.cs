using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        // Read the contents of the text file
        string[] lines = File.ReadAllLines("input.txt");

        // Create a stack to store the lines of the text file
        Stack<string> stack = new Stack<string>();

        // Add each line of the text file to the stack
        foreach (string line in lines)
        {
            stack.Push(line);
        }

        // Output the lines of the text file in reverse order
        while (stack.Count > 0)
        {
            string line = stack.Pop();
            Console.WriteLine(line);
        }
    }
}
