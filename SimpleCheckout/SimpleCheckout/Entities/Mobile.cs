using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleCheckout.Entities
{
    public class Mobile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public decimal Price { get; set; }
        public string ZoomUrl { get; set; }
        public string Description { get; set; }
    }
}