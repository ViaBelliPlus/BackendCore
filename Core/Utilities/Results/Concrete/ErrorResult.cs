﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results.Abstract;

namespace Core.Utilities.Results.Concrete
{
    public class ErrorResult : IErrorResult
    {
        public ErrorResult()
        {
            Success= false;
        }
        public ErrorResult(string message):this()
        {
            Message=message;
        }
        public string Message { get; }

        public bool Success { get; }
    }
}
