﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree136
{
    class node
    {
        public string info;
        public node lchild;
        public node rchild;

        public node(string i, node l, node r)
        {
            info = i;
            lchild = l;
            rchild = r;
        }
    }
    class BinaryTree
    {
        public node root;

        public BinaryTree()
        {
            root = null;
        }
        public void Insert (string element)
        {
            node tmp, parent = null, currentnode = null;
            find(element, ref parent,ref currentnode);
            if(currentnode ! = null)
            {
                Console.WriteLine("dupilicate word  not allowed")
            }
        }
    }
    class Program
    {
        // A node Class const

        static void Main(string[] args)
        {
        }
    }
}
