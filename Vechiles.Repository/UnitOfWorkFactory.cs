using System.Data.Entity;

namespace Vechiles.Repository
{
    public class UnitOfWorkFactory : IUnitOfWorkFactory
    {
        private readonly DbContext _context;

        public UnitOfWorkFactory(DbContext context)
        {
            _context = context;
        }

        public IUnitOfWork Create()
        {
            return new UnitOfWork(_context);
        }
    }
}
