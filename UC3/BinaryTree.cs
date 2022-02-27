using System;
using System.Collections.Generic;
using System.Text;

namespace UC3
{
    class BinaryTree
    {
        public Node root = null;

        public void Add(int i)
        {
            Node node = new Node();
            node.data = i;
            if (root == null)
            {
                root = node;
            }
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (i < current.data)
                    {
                        current = current.LeftNode;
                        if (current == null)
                        {
                            parent.LeftNode = node;
                            break;
                        }
                    }
                    else
                    {
                        current = current.RightNode;
                        if (current == null)
                        {
                            parent.RightNode = node;
                            break;
                        }
                    }

                }
            }
            Console.WriteLine(node.data + " : Data is added");
        }

        public void Traverse(Node root)
        {
            if (root == null)
            {
                return;
            }

            Traverse(root.LeftNode);
            Console.Write(root.data + " ");
            Traverse(root.RightNode);

        }
        public bool Search(Node root, int value)
        {
            if (root == null)
            {
                return false;
            }
            if (root.data == value)
            {
                return true;
            }
            else if (root.data > value)
            {
                return Search(root.LeftNode, value);
            }
            else
            {
                return Search(root.RightNode, value);
            }
        }
    }
}
