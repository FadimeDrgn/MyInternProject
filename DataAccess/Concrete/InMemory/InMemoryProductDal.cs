using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    //public class InMemoryProductDal : IProductDal
    //{
    //    List<Product> _products; //Bu projeyi başlatınca bellekte 
    //    public InMemoryProductDal()
    //    {
    //        //Bir veri tabanından geliyormuş gibi veri oluşturdu
    //        _products = new List<Product> { 
    //            new Product{ProductId=1, CategoryId=1, ProductName="Direnc"},
    //            new Product{ProductId=2, CategoryId=1, ProductName="Arduino"},
    //            new Product{ProductId=3, CategoryId=2, ProductName="Kapasitor"},
    //            new Product{ProductId=4, CategoryId=2, ProductName="Board"},
    //            new Product{ProductId=5, CategoryId=3, ProductName="Ampul"}
    //        };
    //    }
    //    public void Add(Product product)
    //    {
    //        _products.Add(product);
    //    }

    //    public void Delete(Product product)
    //    {
    //        Product productToDelete = null;//Liste ile atama var hata vermemesi için böyle
    //        //foreach (var p in _products) //Gönderdiğimiz productın prodactId'sine eşit olan productı siler
    //        //{
    //        //    productToDelete = p;
    //        //}

    //        productToDelete = _products.SingleOrDefault(p=>p.ProductId == product.ProductId);
    //        //Her p için benim dolaştığım ürünün ıd'si bizim parametreyle gönderdiğimiz ürünün ıd'sine eşitse referansları eşitle
    //        _products.Remove(productToDelete);
    //    }

    //    public Product Get(Expression<Func<Product, bool>> filter)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public List<Product> GetAll()
    //    {
    //        return _products; //Veri tabanından verileri döndürüyor onun için return
    //    }

    //    public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public List<Product> GetAllByCategoryId(int categoryId)
    //    {
    //        return _products.Where(p => p.CategoryId == categoryId).ToList();
    //    }

    //    public List<ProductDetailDto> GetProductDetails()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Update(Product product) 
    //    {
    //        //Güncellemeleri yapıyoruz
    //        Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
    //        productToUpdate.ProductName = product.ProductName;
    //        productToUpdate.CategoryId = product.CategoryId;
    //    }

    //}
}
