using System;
using System.Collections.Generic;
using System.Text;

namespace UC1
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
                root = node;//if root is null assign newNode to root
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
                            parent.LeftNode = node;  //go left
                            break;
                        }
                    }
                    else
                    {
                        current = current.RightNode;
                        if (current == null)
                        {
                            parent.RightNode = node;  //go right
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
    }
}
