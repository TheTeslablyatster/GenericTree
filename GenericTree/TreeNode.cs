using System;

namespace GenericTree
{
    public enum Side
    {
        Left,
        Right,
        None
    }

    public class TreeNode<T> where T : IComparable
    {
        public TreeNode(T value)
        {
            Value = value;
        }
        public T Value { get; set; }

        public TreeNode<T> LeftNode { get; set; }
        public TreeNode<T> RightNode { get; set; }
        public TreeNode<T> ParentNode { get; set; }

        public TreeNode<T> Add(TreeNode<T> node, TreeNode<T> currentNode)
        {
            node.ParentNode = currentNode;

            if (node.Value.CompareTo(currentNode.Value) == 0)
            {
                node.LeftNode = currentNode.LeftNode;
                currentNode.LeftNode.ParentNode = node;
                return currentNode.LeftNode = node;
            }
            else if (node.Value.CompareTo(currentNode.Value) < 0)
                _ = currentNode.LeftNode == null
                    ? currentNode.LeftNode = node
                    : currentNode.Add(node);
            else if (node.Value.CompareTo(currentNode.Value) > 0)
                _ = currentNode.RightNode == null
                    ? currentNode.RightNode = node
                    : currentNode.Add(node);

            return node;
        }







        public Side? NodeSide =>
            ParentNode == null
            ? Side.None
            : ParentNode.LeftNode == this
                ? Side.Left
                : Side.Right;

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
