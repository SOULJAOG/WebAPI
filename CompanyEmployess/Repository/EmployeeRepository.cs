<<<<<<< HEAD
﻿using Entities;
=======
﻿using Contracts;
using Entities;
>>>>>>> lab4
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
<<<<<<< HEAD
    public class EmployeeRepository : RepositoryBase<Employees>, Contracts.IEmployeeRepository
=======
    public class EmployeeRepository : RepositoryBase<Employees>, IEmployeeRepository
>>>>>>> lab4
    {
        public EmployeeRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
        {
        }
<<<<<<< HEAD
=======

        public IEnumerable<Employees> GetEmployees(Guid companyId, bool trackChanges) => FindByCondition(e => e.CompanyId.Equals(companyId), trackChanges).OrderBy(e => e.Name);
        public Employees GetEmployee(Guid companyId, Guid id, bool trackChanges) => FindByCondition(e => e.CompanyId.Equals(companyId) && e.Id.Equals(id), trackChanges).SingleOrDefault();
>>>>>>> lab4
    }
}
