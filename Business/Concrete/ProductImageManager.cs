using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.FileHelpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductImageManager : IProductImageService
    {
        IProductImageDal _productImageDal;

        public ProductImageManager(IProductImageDal productImageDal)
        {
            _productImageDal = productImageDal;
        }

        [ValidationAspect(typeof(ProductImageValidator))]
        public IResult Add(ProductImage productImage, IFormFile formFile)
        {
            IResult result = BusinessRules.Run(CheckProductImageLımıt(productImage.ProductId));

            if (result != null)
            {
                return result;
            }

            var result1 = FileHelper.Add(formFile);
            productImage.ImagePath = result1;
            productImage.Date = DateTime.Now;

            _productImageDal.Add(productImage);
            return new SuccessResult("Ürün resmi eklendi.");
        }

        public IResult Delete(ProductImage productImage)
        {
            IResult result = BusinessRules.Run(CheckForDeleteImage(productImage.ProductImageId));
            if (result != null)
            {
                return result;
            }

            _productImageDal.Delete(productImage);
            return new SuccessResult("Ürün resmi silindi.");
        }

        public IDataResult<List<ProductImage>> GetAll()
        {

            return new SuccessDataResult<List<ProductImage>>(_productImageDal.GetAll());
        }

        public IDataResult<List<ProductImage>> GetByProductId(int productId)
        {
            return new SuccessDataResult<List<ProductImage>>(CheckIfAnyProductImageExists(productId));
        }

        public IDataResult<ProductImage> GetById(int Id)
        {
            return new SuccessDataResult<ProductImage>(_productImageDal.Get(p => p.ProductImageId == Id));
        }

        [TransactionScopeAspect]
        public IResult TransactionalOperation(ProductImage productImage, IFormFile file)
        {
            Add(productImage, file);
            Update(productImage, file);

            return new SuccessResult(Messages.ProductImageUpdated);
        }

        public IResult Update(ProductImage productImage, IFormFile formFile)
        {
            IResult result = BusinessRules.Run(CheckProductImageLımıt(productImage.ProductId));

            if (result != null)
            {
                return result;
            }

            productImage.Date = DateTime.Now;
            _productImageDal.Update(productImage);
            return new SuccessResult("Ürün resmi güncellendi.");
        }

        private IResult CheckProductImageLımıt(int productId)
        {
            var result = _productImageDal.GetAll(p => p.ProductId == productId).Count;
            if (result > 5)
            {
                return new ErrorResult(Messages.CheckProductImageLımıtError);
            }
            return new SuccessResult();
        }

        private IResult CheckForDeleteImage(int id)
        {
            bool result = _productImageDal.GetAll(p => p.ProductImageId == id).Any();
            if (result)
            {
                return new ErrorResult(Messages.CheckProductForDeleteImageError);
            }
            return new SuccessResult();
        }

        private List<ProductImage> CheckIfAnyProductImageExists(int productId)
        {
            string path = @"\images\default.jpg";
            var result = _productImageDal.GetAll(p => p.ProductId == productId).Any();

            if (result)
            {
                return _productImageDal.GetAll(p => p.ProductId == productId);
            }

            return new List<ProductImage> { new ProductImage { ProductId = productId, ImagePath = path, Date = DateTime.Now } };
        }

    }
}
