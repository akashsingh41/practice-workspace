using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monk_Width_BinaryTree
{
    public class Node
    {
        public int value;
        public Node left;
        public Node right;
        //public char[] node_path;

        public Node(int i)
        {
            value = i;
        }

        public Node()
        {
        }

        public int Display()
        {
            return value;
        }
    }
}
