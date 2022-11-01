using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IOrderRepository
    {
       public IEnumerable<Order> GetAllOrder(bool trackChanges);
<<<<<<< HEAD
=======

       public Order GetOrder(Guid OrderyId, bool trackChanges);
>>>>>>> lab4
    }
}
