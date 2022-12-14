using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductImageDal : EfEntityRepositoryBase<ProductImage, MyDbContext>, IProductImageDal
    {
        public bool IsExist(int id)
        {
            using (MyDbContext context = new MyDbContext())
            {
                return context.ProductImages.Any(p => p.ProductImageId == id);
            }
        }
    }
}
