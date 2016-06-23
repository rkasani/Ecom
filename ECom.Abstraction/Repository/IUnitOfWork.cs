namespace ECom.Abstraction.Repository
{
    using System;    
    using System.Data.Entity;
    

    public interface IUnitOfWork : IDisposable
    {
        void Commit();

        DbContext context { get; }

        void StartTransaction();
    }
}
