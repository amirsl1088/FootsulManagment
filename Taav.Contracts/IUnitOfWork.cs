using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taav.Contracts
{
    public interface IUnitOfWork
    {
        Task Begin();
        Task Complete();
        Task Commit();
        Task RollBack();
    }
}
