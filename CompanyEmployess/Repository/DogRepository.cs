using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class DogRepository : RepositoryBase<Dog>, Contracts.IDogRepository
    {
        public DogRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
        {
        }
    }
}
