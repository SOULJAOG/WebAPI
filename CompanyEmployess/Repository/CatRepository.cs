using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CatRepository : RepositoryBase<Cat>, Contracts.ICatRepository
    {
        public CatRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
        {
        }
    }
}
