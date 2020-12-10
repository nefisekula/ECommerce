using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ECommerce.Entities
{
    public class Product : BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        public bool IsNewProduct { get; set; }
        public int Rate { get; set; }
        public string Description { get; set; }
        public bool IsRecommended { get; set; }
        public bool IsBannerProduct { get; set; }
        public virtual int? CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual int? BrandId { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual List<ProductTag> ProductTags { get; set; }
        public virtual List<Picture> Pictures { get; set; }
        public virtual List<Comment> Comments { get; set; }
    }
}
