using System;
using System.Collections.Generic;
using System.Text;

namespace Code_Practice
{
    public static class ConsoleHelper
    {
        public static void  GenerateRandomBackgroundColor()=> Console.ForegroundColor = (ConsoleColor)(new Random()).Next(0, 14);
        public static void InsertEmptyLines(int numberOfLines =1)
        {
            for (int i = 0; i < numberOfLines; i++)
            {
                Console.WriteLine(Environment.NewLine);
            }
        }
        public static void PrintNumbersFromList<T>(List<T> data)
        {
            data.ForEach(value =>
            {
             
                Console.WriteLine(value);
            });
        }
    }
}
