using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
<<<<<<< HEAD
=======
using Entities.Models;
>>>>>>> lab4
=======
using Entities.Models;
>>>>>>> lab5

namespace Contracts
{
    public interface IContentOfOrderRepository
    {
<<<<<<< HEAD
<<<<<<< HEAD
=======
        IEnumerable<ContentOfOrder> GetContentsOfOrder(Guid orderId, bool trackChanges);
        ContentOfOrder GetContentOfOrder(Guid orderId, Guid id, bool trackChanges);

>>>>>>> lab4
=======
        IEnumerable<ContentOfOrder> GetContentsOfOrder(Guid orderId, bool trackChanges);
        ContentOfOrder GetContentOfOrder(Guid orderId, Guid id, bool trackChanges);
        void CreateContentOfOrder(ContentOfOrder order);

        public void CreateContentForOrder(Guid orderId, ContentOfOrder contentOfOrder);
>>>>>>> lab5
    }
}
