using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace assign.Models
{
    public class OrderItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
         [Range(1, 149)]
        public int quantity { get; set; }
        public double price { get; set; }
        public double total { get; set; }
    }
}