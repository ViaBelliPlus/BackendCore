using Core.Utilities.Results.Abstract.Tree.Node;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Abstract.Tree
{
    public interface IBinarySearchTree<T> : IBinaryTreeBase<T> where T : IComparable
    {
        IDataResult<T> FindMax();
        IDataResult<T> FindMin();
        IDataResult<T> MaxDepht();
        IDataResult<INode<T>> DeepNode();
        IResult ToDrawAllPaths();
        IDataResult<INode<T>> FindPath(INode<T> findedRoot);
        IDataResult<INode<T>> FindRoot(T value);
        IDataResult<INode<T>> FindRootDepht(T value);
        IDataResult<INode<T>> FindRootAll(T value);

    }
}
