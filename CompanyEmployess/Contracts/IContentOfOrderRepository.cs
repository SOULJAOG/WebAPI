using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
=======
using Entities.Models;
>>>>>>> lab4

namespace Contracts
{
    public interface IContentOfOrderRepository
    {
<<<<<<< HEAD
=======
        IEnumerable<ContentOfOrder> GetContentsOfOrder(Guid orderId, bool trackChanges);
        ContentOfOrder GetContentOfOrder(Guid orderId, Guid id, bool trackChanges);

>>>>>>> lab4
    }
}
