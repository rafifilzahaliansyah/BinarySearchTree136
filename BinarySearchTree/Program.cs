using System;
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
            if(currentnode != null)
            {
                Console.WriteLine("dupilicate word  not allowed");
                return;
            }
            else
            {
                tmp = new node(element, null, null);
                if (parent == null)
                {
                    root = tmp;
                }
                else if (string.Compare(element,parent.info) <0)
                {
                    if (string.Compare(element, parent.info) < 0)
                        parent.lchild = tmp;
                }
                else
                {
                    parent.rchild = tmp;
                }
            }
        }
        public void find(string element, ref node parent, ref node currentnode)
        {
            currentnode = root;
            parent = null;
            while ((currentnode != null) && (currentnode.info != element))
            {
                parent = currentnode;
                if (string.Compare(element, currentnode.info) < 0)
                    currentnode = currentnode.lchild;
                else
                    currentnode = currentnode.rchild;
            }
        }
        public void inorder(node ptr)
        {
            if (root == null)
            {
                Console.WriteLine("tree is empty");
                return;
            }
            if (ptr != null)
            {
                inorder(ptr.lchild);
                Console.WriteLine(ptr.info + "");
                inorder(ptr.rchild);
            }
        }
        public void preorder(node ptr)
        {
            if (root == null)
            {
                Console.WriteLine("tree is empty");
                return;
            }
            if (ptr !=null)
            {
                Console.WriteLine(ptr.info + "");
                preorder(ptr.lchild);
                preorder(ptr.rchild);
            }
        }
        public void postorder(node ptr)
        {
            if (root == null)
            {
                Console.WriteLine("tree is empty");
                return;
            }
            if (ptr !=null)
            {
                postorder(ptr.lchild);
                postorder(ptr.rchild);
                Console.WriteLine(ptr.info + "");
            }
        }
    }
    class Program
    {
        // A node Class const

        static void Main(string[] args)
        {
            BinaryTree x = new BinaryTree();
            while(true)
            {
                Console.WriteLine("\nMenu");
                Console.WriteLine("1. Implement Insert Operation ");
                Console.WriteLine("2. perform in order treversal ");
                Console.WriteLine("3. perform preorder traversal ");
                Console.WriteLine("4. perform  postorder traversal ");
                Console.WriteLine("5. Exit ");
            }
        }
    }
}
