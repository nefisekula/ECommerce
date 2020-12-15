using ECommerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.UI.Models
{
    public class ProductViewModel
    {
        //pagination
        public int Count { get; set; } = 6;
        public int PageIndex { get; set; }
        public int TotalPageCount { get; set; }
        public List<Product> Products { get; set; }

        //Filters
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
    }
}
