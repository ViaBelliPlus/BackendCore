using Core.Utilities.Results.Abstract.Tree;
using Core.Utilities.Results.Abstract.Tree.Node;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Concrete.Tree
{
    public partial class BinarySearchTree<T> : IBinarySearchTree<T>, IBinaryTreeRamble<T> where T : IComparable
    {
        public INode<T> Root { get; set; }
        public List<INode<T>> list;
        public BinarySearchTree()
        {
            list = new List<INode<T>>();
        }
        public BinarySearchTree(INode<T> root):this()
        {
            Root = root;
        }

        public List<INode<T>> InOrder(INode<T> root)
        {
            throw new NotImplementedException();
        }

        public List<INode<T>> InOrderNR(INode<T> root)
        {
            throw new NotImplementedException();
        }

        public List<INode<T>> PostOrder(INode<T> root)
        {
            throw new NotImplementedException();
        }

        public List<INode<T>> PostOrderNR(INode<T> root)
        {
            throw new NotImplementedException();
        }

        public List<INode<T>> PreOrder(INode<T> root)
        {
            throw new NotImplementedException();
        }

        public List<INode<T>> PreOrderNR(INode<T> root)
        {
            throw new NotImplementedException();
        }

        public List<INode<T>> LevelOrder(INode<T> root)
        {
            throw new NotImplementedException();
        }

        public List<INode<T>> LevelOrderNR(INode<T> root)
        {
            throw new NotImplementedException();
        }
    }
}
