using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SimpleCheckout.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }        
        public int ProductDetailId { get; set; }
        [ForeignKey("ProductDetailId")]
        public ProductDetail ProductDetail { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal Price { get; set; }
    }
}