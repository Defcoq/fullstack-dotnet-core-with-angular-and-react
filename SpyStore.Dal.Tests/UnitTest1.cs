using SpyStore.Dal.EfStructures;
using SpyStore.Models.Entities;
using System;
using System.Collections.Generic;
using Xunit;

namespace SpyStore.Dal.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            StoreContext _context = new StoreContextFactory().CreateDbContext(null);
            var cat = new Category { CategoryName = "CatName" };
            _context.Categories.Add(cat);
            _context.SaveChanges();

            
            var cats = new List<Category>
            {
                new Category {CategoryName = "Cat1Name"},
                new Category {CategoryName = "Cat2Name"},
                new Category {CategoryName = "Cat3Name"},
            };
            _context.Categories.AddRange(cats);
            _context.SaveChanges();

        }
    }
}
