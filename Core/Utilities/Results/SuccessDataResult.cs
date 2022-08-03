using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        public SuccessDataResult(T data, string message):base(data,true,message)
        {

        }
        public SuccessDataResult(T data):base(data, true)//mesaj oalyına girmek istemeybilir
        {

        }
        public SuccessDataResult(string message):base(default,true,message)
        {
            //bir şey döndürmek istemeyince default
        }
        public SuccessDataResult():base(default,true)//hiçbir şey döndürmeyedebilşriz
        {

        }
    }
}
