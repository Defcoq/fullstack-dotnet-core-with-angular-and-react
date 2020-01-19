using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SpyStore.Dal.EfStructures;
using SpyStore.Dal.Repo.Base;
using SpyStore.Dal.Repo.Interfaces;
using SpyStore.Models.Entities;

namespace SpyStore.Dal.Repo
{
    public class CategoryRepo : RepoBase<Category>, ICategoryRepo
    {
        public CategoryRepo(StoreContext context) : base(context)
        {
        }
        internal CategoryRepo(DbContextOptions<StoreContext> options)
        : base(options)
        {

        }

        public override IEnumerable<Category> GetAll()=> base.GetAll(x => x.CategoryName);
    }
}
