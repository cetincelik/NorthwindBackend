using Business.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }
        public Product GetById(int productId)
        {
            EfProuctDal productDal = new EfProuctDal();
            return productDal.Get(p => p.ProductId == productId);
        }

        public List<Product> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetListByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
