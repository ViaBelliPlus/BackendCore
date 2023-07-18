using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Messages
{
    public static class ErrorMessages
    {
        /// <summary>
        /// The referance node is not in relative context
        /// </summary>
        public static string MissingNodeMessage { get; } = "The referance node is not in relative context";
        /// <summary>
        /// The related object is null
        /// </summary>
        public static string NullObjectMessage { get; } = "The related object is null";
        /// <summary>
        /// The searched value was not found in the relevant context
        /// </summary>
        public static string MissingValueMessage { get; } = "The searched value was not found in the relevant context";
        /// <summary>
        /// Incorrect index entry! An index range longer than the list cannot be given!
        /// </summary>
        public static string IndexOutOfRangeMessage { get; } = "Incorrect index entry! An index range longer than the list cannot be given!";
        /// <summary>
        /// Incorrect index entry! A negative range cannot be given!
        /// </summary>
        public static string NegativeRangeMessage { get; } = "Incorrect index entry! A negative range cannot be given!";
        /// <summary>
        /// The node attempted to be deleted is null
        /// </summary>
        public static string NullNodeDeletion { get; } = "The node attempted to be deleted is null";
        /// <summary>
        /// There is not enough space in the directory you are trying to copy
        /// </summary>
        public static string NotEnoughSpaceMessage { get; } = "There is not enough space in the directory you are trying to copy";
        /// <summary>
        /// The relative value must be implemented IComparable
        /// </summary>
        public static string NotComparable { get; } = "The relative value must be implemented IComparable";
    }
}
