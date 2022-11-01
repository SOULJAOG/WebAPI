using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ContentOfOrderRepository : RepositoryBase<ContentOfOrder>, IContentOfOrderRepository
    {
        public ContentOfOrderRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
        {
        }

        public IEnumerable<ContentOfOrder> GetContentsOfOrder(Guid orderId, bool trackChanges) => FindByCondition(e => e.Id.Equals(orderId), trackChanges).OrderBy(e => e.Quantity);
        public ContentOfOrder GetContentOfOrder(Guid orderId, Guid id, bool trackChanges) => FindByCondition(e => e.Id.Equals(orderId) && e.Id.Equals(id), trackChanges).SingleOrDefault();
    }
}
