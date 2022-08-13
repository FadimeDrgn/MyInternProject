using Core.Utilities.Business;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService : IEntityServiceBase<Product>
    {
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        //tek bir ürünün detayı için
        IDataResult<List<Product>> GetAllByCategoryId(int id);
    }
}
