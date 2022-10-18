using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class ContentOfOrder
    {
        [Column("ContentOfOrderId")]
        public Guid Id { get; set; }
        [ForeignKey(nameof(Order))]
        public Guid OrderId { get; set; }
        public string Product { get; set; }
        public string Price { get; set; }
        public string Quantity { get; set; }
        public string Cost { get; set; }
    }
}
