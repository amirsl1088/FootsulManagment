using Footsul.Persistence.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taav.Contracts;

namespace AllBlocks.Persistence.EF
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly EFDataContext _context;
        public EFUnitOfWork(EFDataContext context)
        {
            _context = context;
        }
        public async Task Begin()
        {
          await  _context.Database.BeginTransactionAsync();
        }

        public async Task Commit()
        {
            await _context.Database.CommitTransactionAsync();
        }

        public async Task Complete()
        {
            await _context.SaveChangesAsync();
        }

        public async Task RollBack()
        {
            await _context.Database.RollbackTransactionAsync();
        }
    }
}
