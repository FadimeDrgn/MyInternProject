using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Caching
{
    public interface ICacheManager
    {
        //kullanıcı hangisini kullanmak isterse farklı alternatifler sunduk burada
        T Get<T>(string key);
        object Get(string key);
        void Add(string key, object value, int duration);
        //verinin cache olup olmadığını kontrol eder
        bool IsAdd(string key);
        //bir veriyi cache'den kaldırmak için
        void Remove(string key);
        //parametli olanlarda pattern kullanırız mesela burada deriz ki isminde kategori olanları kaldır
        void RemoveByPattern(string pattern);
    }
}
