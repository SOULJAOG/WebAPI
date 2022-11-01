<<<<<<< HEAD
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
=======
﻿using Contracts;
using Entities;
>>>>>>> lab6
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
<<<<<<< HEAD
    public class ContentOfOrderRepository : RepositoryBase<ContentOfOrder>, Contracts.IContentOfOrderRepository
=======
    public class ContentOfOrderRepository : RepositoryBase<ContentOfOrder>, IContentOfOrderRepository
>>>>>>> lab4
=======
    public class ContentOfOrderRepository : RepositoryBase<ContentOfOrder>, IContentOfOrderRepository
>>>>>>> lab5
=======
    public class ContentOfOrderRepository : RepositoryBase<ContentOfOrder>, IContentOfOrderRepository
>>>>>>> lab6
    {
        public ContentOfOrderRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
        {
        }
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======

        public IEnumerable<ContentOfOrder> GetContentsOfOrder(Guid orderId, bool trackChanges) => FindByCondition(e => e.Id.Equals(orderId), trackChanges).OrderBy(e => e.Quantity);
        public ContentOfOrder GetContentOfOrder(Guid orderId, Guid id, bool trackChanges) => FindByCondition(e => e.Id.Equals(orderId) && e.Id.Equals(id), trackChanges).SingleOrDefault();
>>>>>>> lab4
=======
=======
>>>>>>> lab6

        public IEnumerable<ContentOfOrder> GetContentsOfOrder(Guid orderId, bool trackChanges) => FindByCondition(e => e.Id.Equals(orderId), trackChanges).OrderBy(e => e.Quantity);
        public ContentOfOrder GetContentOfOrder(Guid orderId, Guid id, bool trackChanges) => FindByCondition(e => e.Id.Equals(orderId) && e.Id.Equals(id), trackChanges).SingleOrDefault();
        public void CreateContentOfOrder(ContentOfOrder contetOrder) => Create(contetOrder);

        public void CreateContentForOrder(Guid orderId, ContentOfOrder contentOfOrder)
        {
            contentOfOrder.OrderId = orderId;
            Create(contentOfOrder);
        }
<<<<<<< HEAD
>>>>>>> lab5
=======

        public void DeleteContentOfOrder(ContentOfOrder contentOfOrder)
        {
            Delete(contentOfOrder);
        }
>>>>>>> lab6
    }
}
