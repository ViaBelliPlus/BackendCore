using Core.Utilities.Results.Abstract.Tree.Node;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Concrete.Tree.Node
{
    public class BBTNode<T> : IBinaryNode<T> where T : IComparable
    {
        public T Value { get; set; }
        public IBinaryNode<T> Right { get; set; }
        public IBinaryNode<T> Left { get; set; }
        public int Depht { get; set; }
        public BBTNode(T value)
        {
            Value = value;
        }
        public override string ToString() => $"{Value}";
    }
}
