using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    public class BinaryTree<T> where T : IComparable
    {
        public T nodeData { get; set; }
        public BinaryTree<T> leftTree { get; set; }
        public BinaryTree<T> rightTree { get; set; }
        public int leftCount;
        public int rightCount;

        public BinaryTree(T nodeData)
        {
            this.nodeData = nodeData;
            this.leftTree = null;
            this.rightTree = null;
        }

        public void Insert(T item)
        {
            T currentNodeValue = this.nodeData;
            int value = currentNodeValue.CompareTo(item);
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.leftTree == null)
                {
                    this.leftTree = new BinaryTree<T>(item);
                    Console.WriteLine("Inserting " + item);
                }
                else
                    this.leftTree.Insert(item);
            }

            else
            {
                if (this.rightTree == null)
                {
                    this.rightTree = new BinaryTree<T>(item);
                    Console.WriteLine("Inserting " + item);
                }
                else
                {
                    this.rightTree.Insert(item);
                    Console.WriteLine("Inserting " + item);
                }

            }
        }
        public void Display()
        {
            if (this.leftTree != null)
            {
                this.leftCount++;
                this.leftTree.Display();
            }
            Console.WriteLine(this.nodeData.ToString());
            if (this.rightTree != null)
            {
                this.rightCount++;
                this.rightTree.Display();
            }

        }

        public void GetSize()
        {
            Console.WriteLine("Size" + " " + (1 + this.leftCount + this.rightCount));
        }
    }
}
