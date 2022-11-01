using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
    public class OrderDto
    {    
        public Guid Id { get; set; }
        public Guid UserId { get; set; }

        public string CustomerName { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfDelivery { get; set; }
        public DateTime DateOfIssue { get; set; }
<<<<<<< HEAD
<<<<<<< HEAD
=======

        public IEnumerable<ContentOfOrderForCreationDto> ContentOfOrder { get; set; }

>>>>>>> lab5
=======

        public IEnumerable<ContentOfOrderForCreationDto> ContentOfOrder { get; set; }

>>>>>>> lab6
    }
}
