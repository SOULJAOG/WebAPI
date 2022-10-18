using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UserRepository : RepositoryBase<User>, Contracts.IUserRepository
    {
        public UserRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
        {
        }
    }
}
