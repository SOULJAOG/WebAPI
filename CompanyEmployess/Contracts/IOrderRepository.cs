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

       public Order GetOrder(Guid OrderyId, bool trackChanges);

        void CreateOrder(Order order);

        IEnumerable<Order> GetByIds(IEnumerable<Guid> ids, bool trackChanges);
       
        void DeleteOrder(Order order);
    }
}
