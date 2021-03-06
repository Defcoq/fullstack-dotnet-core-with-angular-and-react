﻿using SpyStore.Models.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SpyStore.Models.Entities
{
    [Table("Orders", Schema = "Store")]
    public class Order : OrderBase
    {
        [InverseProperty(nameof(OrderDetail.OrderNavigation))]
        public List<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
        [ForeignKey(nameof(CustomerId))]
        public Customer CustomerNavigation { get; set; }
    }
}
