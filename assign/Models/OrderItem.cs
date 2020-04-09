using System;
using System.Collections.Generic;

namespace assign.Models
{
    public class OrderItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
        public double total { get; set; }
    }
}