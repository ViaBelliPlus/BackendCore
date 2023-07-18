using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : IErrorDataResult<T>
    {
        public ErrorDataResult()
        {
            Success = false;
        }
        public ErrorDataResult(string message) : this()
        {
            Message = message;
        }
        public ErrorDataResult(T data) : this()
        {
            Data = data;
        }
        public ErrorDataResult(string message, T data) : this(message)
        {
            Data = data;
        }

        public T Data { get; }
        public string Message { get; private set; }
        public bool Success { get; }
    }
}
