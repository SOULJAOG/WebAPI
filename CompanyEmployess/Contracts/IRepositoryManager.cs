using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositoryManager
    {
        ICompanyRepository Company { get; }
        IEmployeeRepository Employee { get; }
<<<<<<< HEAD
        IUserRepository User { get; }
        IOrderRepository Order { get; }
        IContentOfOrderRepository ContentOfOrder { get; }
=======
        ICatRepository Cat { get; }
        IDogRepository Dog { get; }
>>>>>>> aef9d58cbf25c431223056766df7d4e832365b72
        void Save();
    }
}
