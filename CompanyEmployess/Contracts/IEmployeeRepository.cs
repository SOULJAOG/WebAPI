using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
using Entities.Models;
>>>>>>> lab4
=======
using Entities.Models;
>>>>>>> lab5
=======
using Entities.Models;
>>>>>>> lab6

namespace Contracts
{
    public interface IEmployeeRepository
    {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
        IEnumerable<Employees> GetEmployees(Guid companyId, bool trackChanges);
        Employees GetEmployee(Guid companyId, Guid id, bool trackChanges);
       
>>>>>>> lab4
=======
        IEnumerable<Employees> GetEmployees(Guid companyId, bool trackChanges);
        Employees GetEmployee(Guid companyId, Guid id, bool trackChanges);
        void CreateEmployeeForCompany(Guid companyId, Employees employee);

>>>>>>> lab5
=======
        IEnumerable<Employees> GetEmployees(Guid companyId, bool trackChanges);
        Employees GetEmployee(Guid companyId, Guid id, bool trackChanges);
        void CreateEmployeeForCompany(Guid companyId, Employees employee);
        void DeleteEmployee(Employees employee);
>>>>>>> lab6
    }
}
