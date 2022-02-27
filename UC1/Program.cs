using System;

namespace UC1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree Program.");
            BinaryTree binarytree = new BinaryTree();

            binarytree.Add(56);
            binarytree.Add(30);
            binarytree.Add(70);

           
            binarytree.Traverse(binarytree.root);
            
        }
    }
}
