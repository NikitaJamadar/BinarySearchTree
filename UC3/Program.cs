using System;

namespace UC3
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
            binarytree.Add(22);
            binarytree.Add(40);
            binarytree.Add(60);
            binarytree.Add(95);
            binarytree.Add(11);
            binarytree.Add(65);
            binarytree.Add(3);
            binarytree.Add(16);
            binarytree.Add(63);
            binarytree.Add(67);

            
            binarytree.Traverse(binarytree.root);
            Console.WriteLine();

            bool isFound = binarytree.Search(binarytree.root, 63);
            Console.WriteLine("63 is found " + isFound);
        }
    }
}
