using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Order
    {
        [Column("OrderId")]
        public Guid Id { get; set; }
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
  
=======
       
>>>>>>> lab4
=======

>>>>>>> lab5
=======

>>>>>>> lab6
        public string CustomerName { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfDelivery { get; set; }
        public DateTime DateOfIssue { get; set; }
    }
}
