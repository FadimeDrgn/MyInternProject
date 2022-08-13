using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper
    {
        //verdiğimiz passwordün hash'ini oluşturacak
        //out dışarıya vereceğimiz değer
        //Bu kod ile verdiğimiz bir değerin hash ve salt kodlarını oluşturuyoruz
        public static void CreatePasswordHash
            (string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            //hmac: bizim cryptography sınıfında kullandığımız class'a karşılık
            //Burada SHA512 algoritmasını kullanacağız, saltta üretiyor bu
            //HMACSHA512 aynı zaman da bize bir class üretiyor () yapmalı
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                //key değeri ilgili kullandığımız algoritmanın o an oluşturduğu değer, her kullanıcı için yeni bir key oluşturur
                passwordSalt = hmac.Key;
                //computeHAsh'i byte[] olarak vermemiz gerekiyor onu da alttaki yöntemle yaparız
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        //passwordHas'i doğrular
        //out olmamalı çünkü bu değerleri biz vereceğiz
        //veritabanımızdaki hashimiz olacak bu hash'le kullanıcının gönderdiği passwordün oluşacak hash'ini karşılaştırıyoruz, salt'ı d devreye sokuyoruz
        public static bool VerifyPasswordHash(string password,  byte[] passwordHash,  byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                //passworsalt ile gönderilen hash ve oluşan hash karşılaştırılır
                //computehash: hesaplanan hash-- oluşan değer de bir byte[]'dir
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    //gönderilen hash ve computeHash eşit mi?
                    if (computedHash[i]!=passwordHash[i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
