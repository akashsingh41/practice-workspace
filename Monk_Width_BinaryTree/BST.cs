using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monk_Width_BinaryTree
{
    class BT
    {
        public Node root;

        public BT()
        {
            root = null;
        }
        /// <summary>
        /// method to add a new node with provided value to the binary tree
        /// </summary>
        /// <param name="x">the value of the node that has to be added to the binary tree</param>
        public void AddNode(int x)
        {
            Node new_node = new Node(x);
            if (root == null)
            {
                root = new_node;
            }
            else
            {
                Node current, parent;
                current = root;
                while (true)
                {
                    parent = current;
                    if (current == null)
                    {
                        current = new_node;
                        break;
                    }

                    if (x < current.value)
                    {
                        current = current.left;
                        if (current == null)
                        {
                            parent.left = new_node;
                            break;
                        }
                    }
                    else
                    {
                        current = current.right;
                        if (current == null)
                        {
                            parent.right = new_node;
                            break;
                        }
                     }
                }
            }
        }

        /// <summary>
        /// method to print out the sequence for in-order traversal
        /// </summary>
        /// <param name="root">the root element node</param>
        public void InOrderTraversal(Node root)
        {
            if (root != null)
            {
                InOrderTraversal(root.left);
                Console.Write(root.Display()+" ");
                InOrderTraversal(root.right);
            }
        }

        /// <summary>
        /// method to print out the sequence for pre-order traversal
        /// </summary>
        /// <param name="root">the root element node</param>
        public void PreOrderTraversal(Node root)
        {
            if (root != null)
            {
                Console.Write(root.Display() + " ");
                PreOrderTraversal(root.left);
                PreOrderTraversal(root.right);
            }
        }

        /// <summary>
        /// method to print out the sequence for post-order traversal
        /// </summary>
        /// <param name="root">the root element node</param>
        public void PostOrderTraversal(Node root)
        {
            if (root != null)
            {
                PostOrderTraversal(root.left);
                PostOrderTraversal(root.right);
                Console.Write(root.Display() + " ");
            }
        }

        /// <summary>
        /// method to return the least valued number that belongs to this binary tree
        /// </summary>
        /// <returns>least integer in the binary tree</returns>
        public int FindMin()
        {
            Node current = root;
            while (current.left != null)
                current = current.left;

            return current.value;
        }

        /// <summary>
        /// method to return the highest valued number that belongs to this binary tree
        /// </summary>
        /// <returns>highest integer in the binary tree</returns>
        public int FindMax()
        {
            Node current = root;
            while (current.right != null)
                current = current.right;

            return current.value;
        }

        /// <summary>
        /// method to return the node that belongs to this binary tree having the particular value
        /// </summary>
        /// <returns>single specific node of this binary tree</returns>
        public Node Find(int x)
        {
            Node current = new Node();
            current = root;
            while (root.value != x)
            {
                if (x < current.value)
                    current = current.left;
                else
                    current = current.right;

                if (current == null)
                    return null;
            }
            return current;
        }
    }
}
