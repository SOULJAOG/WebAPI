using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
=======
using Entities.Models;
>>>>>>> lab4

namespace Contracts
{
    public interface IEmployeeRepository
    {
<<<<<<< HEAD
=======
        IEnumerable<Employees> GetEmployees(Guid companyId, bool trackChanges);
        Employees GetEmployee(Guid companyId, Guid id, bool trackChanges);
       
>>>>>>> lab4
    }
}
