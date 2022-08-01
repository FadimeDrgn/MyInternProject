using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //generic constraint: generic sınırlama demek her tipi kabul etmesin
    //class : referans tipi class olsun demek
    //IEntity: IEntity olabilir IEntity implemente eden bir nesne olabilir
    //new() : new'lenebilir olmalı, böylelikle Ientity devre dışı bıraktık ama IEntity implemente eden bir class olabilir  
    public interface IEntityRepository<T> where T:class, IEntity,new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null); //Expression sayesinde ayrı ayrı filtreleme elemanları yazmamıza gerek kalmaz
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
