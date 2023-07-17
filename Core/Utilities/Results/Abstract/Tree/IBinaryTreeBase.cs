using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results.Abstract.Tree.Node;

namespace Core.Utilities.Results.Abstract.Tree
{
    public interface IBinaryTreeBase<T> where T : IComparable
    {
        IResult Add(T value);
        IResult AddRange(List<T> values);

        IResult Remove(INode<T> value);
        IResult Remove(T value);
        IResult RemoveAll(T value);
        IResult RemoveAll(INode<T> value);
        IResult RemoveRange(List<T> values);

        IResult Clear();

    }
}
