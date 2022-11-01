using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
    public class OrderForCreationDto
    {    
        public Guid Id { get; set; }
        public Guid UserId { get; set; }

        public string CustomerName { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfDelivery { get; set; }
        public DateTime DateOfIssue { get; set; }
    }
}
