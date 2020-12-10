using System.ComponentModel.DataAnnotations;

namespace ECommerce.Entities
{
    public class Comment : BaseEntity
    {
        [Required, StringLength(50)]
        public string Comments { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
