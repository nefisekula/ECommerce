using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Entities
{
    public class Brand : BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
