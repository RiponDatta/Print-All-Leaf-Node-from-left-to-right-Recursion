using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_All_Leaf_Node_from_left_to_right_Recursion
{
    public class Node
    {
        public int Data;
        public Node Left, Right;

        public Node(int data)
        {
            Data = data;
            Left = Right = null;
        }
    }
}
