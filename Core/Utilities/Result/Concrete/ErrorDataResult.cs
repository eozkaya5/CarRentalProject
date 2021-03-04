using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Result.Concrete
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        private string userNotFound;
        private string passwordError;

        public ErrorDataResult(T data, string message) : base(data, false, message)
        {

        }
        public ErrorDataResult(T data) : base(data, false)
        {

        }

      
    }
}
