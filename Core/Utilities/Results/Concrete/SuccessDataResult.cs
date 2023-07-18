using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : ISuccessDataResult<T>
    {
        public SuccessDataResult()
        {
            Success = true;
        }
        public SuccessDataResult(string message) : this()
        {
            Message = message;
        }
        public SuccessDataResult(T data) : this()
        {
            Data = data;
        }
        public SuccessDataResult(string message, T data) : this(message)
        {
            Data = data;
        }
        public T Data { get; }

        public string Message { get; }

        public bool Success { get; }
    }
}
