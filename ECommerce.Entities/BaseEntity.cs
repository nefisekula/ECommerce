using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities
{
    public class BaseEntity
    {
        public int ID { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedTime { get; set; }
    }
}
