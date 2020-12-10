using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ECommerce.Entities
{
    public class Tag : BaseEntity
    {
        [Required, StringLength(20)]
        public string Name { get; set; }
        public virtual List<ProductTag> ProductTags { get; set; }
    }
}
