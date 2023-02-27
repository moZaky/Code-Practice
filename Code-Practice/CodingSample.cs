using Code_Practice.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Code_Practice
{
    public static class CodingSample
    {
        #region treeNode
        public static List<int> TreeNodeSolution(TreeNode t)
        {

            var jsonString = JsonConvert.SerializeObject(TreeNodeValue());

            string codingHint = $"using type script, Note: Try to solve this task without using recursion, since this is what you'll be asked to do during an interview. Given a binary tree of integers t, return its node values in the following format: The first element should be the value of the tree root; The next elements should be the values of the nodes at height 1 (i.e. the root children), ordered from the leftmost to the rightmost one; The elements after that should be the values of the nodes at height 2 (i.e. the children of the nodes at height 1) ordered in the same way; Etc." +
                $"Example For t = {jsonString}the output should be solution(t) = [1, 2, 4, 3, 5]. This t looks like this: 1 / \\ 2 4 \\ / 3 5 Input/Output [execution time limit] 5 seconds (ts) [input] tree.integer t Guaranteed constraints: 0 ≤ tree size ≤ 104. [output] array.integer An array that contains the values at t's nodes, ordered as described above.";
            ConsoleHelper.InsertEmptyLines();
            Console.WriteLine(codingHint);

            List<int> result = new List<int>();
            List<TreeNode> nodes = new List<TreeNode>();
            nodes.Add(t);

            int i = 0;
            while (i < nodes.Count)
            {
                TreeNode node = nodes[i];
                result.Add(node.Value);
                if (node.Left != null)
                {
                    nodes.Add(node.Left);
                }
                if (node.Right != null)
                {
                    nodes.Add(node.Right);
                }
                i++;
            }
            ConsoleHelper.InsertEmptyLines();
            return result;
        }
        public static TreeNode TreeNodeValue()
        {
            var t = new TreeNode
            {
                Value = 1,
                Left = new TreeNode
                {
                    Value = 2,
                    Left = null,
                    Right = new TreeNode
                    {
                        Value = 3,
                        Left = null,
                        Right = null
                    }
                },
                Right = new TreeNode
                {
                    Value = 4,
                    Left = new TreeNode
                    {
                        Value = 5,
                        Left = null,
                        Right = null
                    },
                    Right = null
                }
            };
            return t;
        }
        #endregion
        public static int ArithmeticMeanoftheNeighborsSolution(int[] a)
        {
            string codingHint = @"You are given an array of integers a. Your task is to calculate how many numbers in the array are equal to the arithmetic mean of their immediate neighbors.In other words, count the number of indices i such that a[i] = (a[i - 1] + a[i + 1]) / 2.Note: If a[i - 1] or a[i + 1] don't exist, they should be considered equal to 0.ExampleFor a = [2, 4, 6, 6, 3], the output should be solution(a) = 3.";
            ConsoleHelper.InsertEmptyLines();
            Console.WriteLine(codingHint);
            int count = 0; // Initialize counter to 0
            int n = a.Length; // Get the length of the input array     // Loop over the array starting from the second element and ending at the second-to-last element
            for (int i = 1; i < n - 1; i++)
            {
                // Check if the current element is equal to the average of its immediate neighbors
                if (a[i] == (a[i - 1] + a[i + 1]) / 2)
                {
                    count++; // Increment the counter if the condition is true
                }
            }     // Check the first element separately
            if (n > 1 && a[0] == a[1] / 2)
            {
                count++; // Increment the counter if the condition is true
            }     // Check the last element separately
            if (n > 1 && a[n - 1] == a[n - 2] / 2)
            {
                count++; // Increment the counter if the condition is true
            }
            ConsoleHelper.InsertEmptyLines();
            return count; // Return the final count
        }
    }
}
