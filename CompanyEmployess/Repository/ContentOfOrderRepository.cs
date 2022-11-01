<<<<<<< HEAD
<<<<<<< HEAD
﻿using Entities;
=======
﻿using Contracts;
using Entities;
>>>>>>> lab4
=======
﻿using Contracts;
using Entities;
>>>>>>> lab5
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
<<<<<<< HEAD
<<<<<<< HEAD
    public class ContentOfOrderRepository : RepositoryBase<ContentOfOrder>, Contracts.IContentOfOrderRepository
=======
    public class ContentOfOrderRepository : RepositoryBase<ContentOfOrder>, IContentOfOrderRepository
>>>>>>> lab4
=======
    public class ContentOfOrderRepository : RepositoryBase<ContentOfOrder>, IContentOfOrderRepository
>>>>>>> lab5
    {
        public ContentOfOrderRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
        {
        }
<<<<<<< HEAD
<<<<<<< HEAD
=======

        public IEnumerable<ContentOfOrder> GetContentsOfOrder(Guid orderId, bool trackChanges) => FindByCondition(e => e.Id.Equals(orderId), trackChanges).OrderBy(e => e.Quantity);
        public ContentOfOrder GetContentOfOrder(Guid orderId, Guid id, bool trackChanges) => FindByCondition(e => e.Id.Equals(orderId) && e.Id.Equals(id), trackChanges).SingleOrDefault();
>>>>>>> lab4
=======

        public IEnumerable<ContentOfOrder> GetContentsOfOrder(Guid orderId, bool trackChanges) => FindByCondition(e => e.Id.Equals(orderId), trackChanges).OrderBy(e => e.Quantity);
        public ContentOfOrder GetContentOfOrder(Guid orderId, Guid id, bool trackChanges) => FindByCondition(e => e.Id.Equals(orderId) && e.Id.Equals(id), trackChanges).SingleOrDefault();
        public void CreateContentOfOrder(ContentOfOrder contetOrder) => Create(contetOrder);

        public void CreateContentForOrder(Guid orderId, ContentOfOrder contentOfOrder)
        {
            contentOfOrder.OrderId = orderId;
            Create(contentOfOrder);
        }
>>>>>>> lab5
    }
}
