﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UC2
{
    class Node
    {
        public int data;
        public Node LeftNode;
        public Node RightNode;
        public Node()
        {
            this.LeftNode = null;
            this.RightNode = null;
        }
    }
}
