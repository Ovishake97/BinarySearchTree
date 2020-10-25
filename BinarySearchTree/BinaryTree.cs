using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    public class BinaryTree<T> where T : IComparable
    {
        /// Binary tree class is created with a node data 
        /// and two corresponding right and left trees 
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

        /// Method compares the user given item with the node data and
        /// accordingly it adds the data to the left or to the right tree
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
        /// Method to search an element in a tree
        /// by traversing through the left and right trees respectively

        public void Search(T item)
        {
            T currentValue = this.nodeData;
            int value = currentValue.CompareTo(item);
            if (value == 0) {
                Console.WriteLine("Found "+item);
            }
           else if (value > 0)
            {
                if (this.leftTree == null)
                {
                    Console.WriteLine(item+" not found");
                }
                else
                    this.leftTree.Search(item);
            }

            else
            {
                if (this.rightTree == null)
                {
                    Console.WriteLine(item+" not found");
                }
                else
                {
                    this.rightTree.Search(item);
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
        /// Gets the size of the tree
        public void GetSize()
        {
            Console.WriteLine("Size" + " " + (1 + this.leftCount + this.rightCount));
        }
    }
}
