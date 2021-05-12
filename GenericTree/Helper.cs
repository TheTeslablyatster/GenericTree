using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTree
{
    public static class Helper
    {
        public static TreeNode<T> Add<T>(this TreeNode<T> currentNode, TreeNode<T> node)
        {
            return currentNode.Add(currentNode, node);
        }
    }
}
