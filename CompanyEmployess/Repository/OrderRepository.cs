﻿using Contracts;
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

        public IEnumerable<Order> GetAllOrder(bool trackChanges) => FindAll(trackChanges).OrderBy(c => c.Id)
        .ToList();

        public Order GetOrder(Guid orderId, bool trackChanges) => FindByCondition(c => c.Id.Equals(orderId), trackChanges).SingleOrDefault();

        public void CreateOrder(Order order) => Create(order);

        public IEnumerable<Order> GetByIds(IEnumerable<Guid> ids, bool trackChanges) =>FindByCondition(x => ids.Contains(x.Id), trackChanges).ToList();

        public void DeleteOrder(Order order)
        {
            Delete(order);
        }
    }
}
