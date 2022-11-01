using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;



namespace Repository
{
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
        {
        }

<<<<<<< HEAD
<<<<<<< HEAD
        public IEnumerable<Order> GetAllOrder(bool trackChanges) => FindAll(trackChanges).OrderBy(c => c.CustomerName)
        .ToList();
       
=======
        public IEnumerable<Order> GetAllOrder(bool trackChanges) => FindAll(trackChanges).OrderBy(c => c.UserId)
=======
        public IEnumerable<Order> GetAllOrder(bool trackChanges) => FindAll(trackChanges).OrderBy(c => c.Id)
>>>>>>> lab5
        .ToList();

        public Order GetOrder(Guid orderId, bool trackChanges) => FindByCondition(c => c.Id.Equals(orderId), trackChanges).SingleOrDefault();

<<<<<<< HEAD
>>>>>>> lab4
=======
        public void CreateOrder(Order order) => Create(order);

        public IEnumerable<Order> GetByIds(IEnumerable<Guid> ids, bool trackChanges) =>FindByCondition(x => ids.Contains(x.Id), trackChanges).ToList();

>>>>>>> lab5
    }
}
