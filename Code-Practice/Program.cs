using System;
using System.Linq;

namespace Code_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleHelper.GenerateRandomBackgroundColor();
            Console.WriteLine("Tree Node Solution");

            var treeNodeResult = CodingSample.TreeNodeSolution(CodingSample.TreeNodeValue());
            Console.WriteLine($"Tree Node Solution Result -> ");
            ConsoleHelper.PrintNumbersFromList(treeNodeResult);
            ConsoleHelper.InsertEmptyLines(1);


            ConsoleHelper.GenerateRandomBackgroundColor();
            Console.WriteLine("Arithmetic Mean of the Neighbors Solution");
            var arithmeticResult = CodingSample.TreeNodeSolution(CodingSample.TreeNodeValue());
            Console.WriteLine($"Arithmetic Mean of the Neighbors Solution Result -> ");

            ConsoleHelper.PrintNumbersFromList(arithmeticResult);
            ConsoleHelper.InsertEmptyLines(1);

            Console.ReadLine();
        }
    }
}
