using System;
using System.Collections.Generic;
using System.Text;
using SpyStore.Dal.Repo.Base;
using SpyStore.Models.Entities;

namespace SpyStore.Dal.Repo.Interfaces
{
    public interface IProductRepo : IRepo<Product>
    {
        IList<Product> Search(string searchString);
        IList<Product> GetProductsForCategory(int id);
        IList<Product> GetFeaturedWithCategoryName();
        Product GetOneWithCategoryName(int id);
    }
}
