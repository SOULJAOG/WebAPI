using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;

namespace Contracts
{
    public interface IContentOfOrderRepository
    {
        IEnumerable<ContentOfOrder> GetContentsOfOrder(Guid orderId, bool trackChanges);
        ContentOfOrder GetContentOfOrder(Guid orderId, Guid id, bool trackChanges);
        void CreateContentOfOrder(ContentOfOrder order);

        public void CreateContentForOrder(Guid orderId, ContentOfOrder contentOfOrder);
    }
}
