using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTree
{
    class Tree<T> where T: IComparable
    {
        private TreeNode<T> Root { get; set; }

        public Tree(TreeNode<T> cell = null)
        { this.Root = cell; }

        public void Add(T value)
        {
            TreeNode<T> node = new TreeNode<T>(value);

            if (Root == null)
            {
                Root = node;
                return;
            }
            else
                Root.Add(node);
        }
    }
}
