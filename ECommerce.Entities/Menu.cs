using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Entities
{
    public class Menu : BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; }
        [Required, StringLength(50)]
        public string Url { get; set; }
        public virtual int? MenuId { get; set; }
        public virtual List<Menu> Menus { get; set; }
    }
}
