using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Abstract.Tree
{
    public interface IAVL<T>:IBinaryBalanceTree<T>,IBinarySearchTree<T> where T : IComparable
    {
    }
}
