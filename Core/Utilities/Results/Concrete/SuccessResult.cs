using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;

namespace Core.Utilities.Results
{
    public class SuccessResult : ISuccessResult
    {
        public SuccessResult()
        {
            Success = true;
        }
        public SuccessResult(string message) : this()
        {
            Message = message;
        }
        public string Message { get; }

        public bool Success { get; }
    }
}
