using System;
using System.Xml.Linq;

public class Assignment133
{
    /*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

    public class Solution
    {
        Dictionary<Node, Node> reference = new Dictionary<Node, Node>();
        public bool CheckClone(Node node)
        {
            if (reference.ContainsKey(node)) return true;

            reference.Add(node, new Node(node.val));
            return false;
        }

        public void DeepClone(Node node)
        {
            if (CheckClone(node)) return;

            for (int i = 0; i < node.neighbors.Count; i++)
            {
                DeepClone(node.neighbors[i]);
                reference[node].neighbors.Add(reference[node.neighbors[i]]);
            }
        }

        public Node CloneGraph(Node node)
        {
            if (node == null) return null;

            DeepClone(node);

            return reference[node];
        }
    }
}
