using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Tree");
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.CreateTree();
            binaryTree.AddToTree();
            binaryTree.Display();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
