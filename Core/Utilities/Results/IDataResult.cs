using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public interface IDataResult< out T>:IResult//Mesaj ve işlem sonucunu bu zaten döndürüyor
    {
        T Data { get; }
    }
}
