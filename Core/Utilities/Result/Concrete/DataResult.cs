using Core.Utilities.Result.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Result.Concrete
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data, bool success, string message) : base(success)
        {
            Data = data;
        }
        public DataResult(T data, bool deliver) : base(deliver)
        {
            Data = data;
        }
        public T Data { get; }
    }
}
