using System;

namespace Vechiles.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        void Flush();
    }
}
