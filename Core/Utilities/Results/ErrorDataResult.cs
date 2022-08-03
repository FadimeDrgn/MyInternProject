using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {

        }
        public ErrorDataResult(T data) : base(data, false)//mesaj oalyına girmek istemeybilir
        {

        }
        public ErrorDataResult(string message) : base(default, false, message)
        {
            //bir şey döndürmek istemeyince default
        }
        public ErrorDataResult() : base(default, false)//hiçbir şey döndürmeyedebilşriz
        {

        }
    }
}
