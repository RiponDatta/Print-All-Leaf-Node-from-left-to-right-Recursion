using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_All_Leaf_Node_from_left_to_right_Recursion
{
    public class BinaryTree
    {
        public Node Root;
        private Queue<Node> Nodes;

        public Queue<Node> GetLeafNodes()
        {
            Nodes = new Queue<Node>();
            GetLeafNodes(Root);
            return Nodes;
        }

        private void GetLeafNodes(Node node)
        {
            if(node==null)
            {
                return;
            }
            if(node.Left == null && node.Right == null)
            {
                Nodes.Enqueue(node);
                return;
            }
            if(node.Left != null)
            {
                GetLeafNodes(node.Left);
            }
            if (node.Right != null)
            {
                GetLeafNodes(node.Right);
            }
        }

        public void PrintNode(Queue<Node> nodes)
        {
            while (nodes.Count > 0)
            {
                var current = nodes.Dequeue();
                Console.Write(current.Data + " ");
            }
        }
    }
}
