namespace ECom.Abstraction.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
 

    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll(Func<T, bool> predicate = null);
        T Get(Func<T, bool> predicate);
        IQueryable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties);
        void Add(T entity);
        void Attach(T entity);
        void Delete(T entity);
        
    }
}
