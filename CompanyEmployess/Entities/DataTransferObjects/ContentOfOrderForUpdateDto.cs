using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
    public class ContentOfOrderForUpdateDto
    {
 
        public string Product { get; set; }
        public string Price { get; set; }
        public string Quantity { get; set; }
        public string Cost { get; set; }
    }
}
