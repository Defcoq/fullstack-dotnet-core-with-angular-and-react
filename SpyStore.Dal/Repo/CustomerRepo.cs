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
    public class CustomerRepo : RepoBase<Customer>, ICustomerRepo
    {
        public CustomerRepo(StoreContext context) : base(context)
        {
        }
        internal CustomerRepo(DbContextOptions<StoreContext> options)
        : base(options)
        {
        }

        public override IEnumerable<Customer> GetAll()=> base.GetAll(x => x.FullName);
    }
}
