using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Abstract.Tree
{
    public interface IBinaryBalanceTree<T> : IBinaryTreeBase<T> where T : IComparable
    {
        IDataResult<T> RightRotation();
        IDataResult<T> LeftRotation();
        IDataResult<T> FindMax();
        IDataResult<T> GetBalance();

    }
}
