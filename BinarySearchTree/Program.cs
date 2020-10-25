using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> tree = new BinaryTree<int>(56);
            tree.Insert(70);
            tree.Insert(30);
            tree.Display();
        }
    }

}