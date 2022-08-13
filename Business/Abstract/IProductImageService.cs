using Core.Utilities.Business;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductImageService 
    {
        IResult Add(IFormFile formFile, ProductImage productImage);
        IResult Delete(ProductImage productImage);
        IResult Update(IFormFile file, ProductImage productImage);

        IDataResult<List<ProductImage>> GetAll();
        IDataResult<ProductImage> GetById(int Id);

        IDataResult<List<ProductImage>> GetByProductId(int productId);
        IResult TransactionalOperation(ProductImage productImage, IFormFile file);
    }
}
