using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.ErrorMessages
{
    public static class ErrorMessages
    {
        public static string MissingNodeMessage { get; } = "The referance node is not in relative context";
        public static string NullObjectMessage { get; } = "The related object is null";
        public static string MissingValueMessage { get; } = "The searched value was not found in the relevant context";
        public static string IndexOutOfRangeMessage { get; } = "Incorrect index entry! An index range longer than the list cannot be given!";
        public static string NegativeRangeMessage { get; } = "Incorrect index entry! A negative range cannot be given!";
        public static string NullNodeDeletion { get; } = "The node attempted to be deleted is null";
        public static string NotEnoughSpaceMessage { get; } = "There is not enough space in the directory you are trying to copy";
        public static string NotComparable { get; } = "The relative value must be implemented IComparable";
    }
}
