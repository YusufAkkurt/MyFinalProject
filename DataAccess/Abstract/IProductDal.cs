using Entities.Concrete;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAll();
        List<Product> GetAllByCategory(int categoryId);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}