using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.JWT
{
    //belki başka bir teknik oluşturmak isteyebiliriz diye
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
        //Kullanıcı kullanıcı adı ve parolayı girdi eğer doğruysa createToken çalışacak
        //Eğer doğruysa ilgili kullanıcı için veri tabanına gidecek veri tabanından bu kullanıcının claimlerini bulacak
        //orada bir tane jwt üretecek içerisinde bu bilgileri barındıran onları apıden arayüze gönderecek
        //Claims: Sisteme giriş yapan kullanıcının ek bilgilerininn tutulduğu yapı
    }
}
