using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, MyDbContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (MyDbContext context = new MyDbContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             select new ProductDetailDto 
                             {ProductId =p.ProductId, ProductName= p.ProductName, CategoryName= c.CategoryName
                             };
                return result.ToList();
            }
        }
    }
}
