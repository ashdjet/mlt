using System;
using System.Collections.Generic;

namespace assign.Models
{
    public class Order
    {
        public int ID { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }

    }
}