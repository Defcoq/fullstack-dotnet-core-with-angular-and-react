﻿using System;
using System.Collections.Generic;
using System.Text;
using SpyStore.Dal.Repo.Base;
using SpyStore.Models.Entities;
using SpyStore.Models.ViewModels;

namespace SpyStore.Dal.Repo.Interfaces
{
    public interface IShoppingCartRepo : IRepo<ShoppingCartRecord>
    {
        CartRecordWithProductInfo GetShoppingCartRecord(int id);
        IEnumerable<CartRecordWithProductInfo> GetShoppingCartRecords(int customerId);
        CartWithCustomerInfo GetShoppingCartRecordsWithCustomer(int customerId);
        ShoppingCartRecord GetBy(int productId);
        int Update(ShoppingCartRecord entity, Product product, bool persist = true);
        int Add(ShoppingCartRecord entity, Product product, bool persist = true);
        int Purchase(int customerId);
    }
}
