namespace ECom.Abstraction.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using ECom.DataModel;
    using System.Data.Entity;

    public class GenericRepository<T> : IRepository<T> where T : class 
    {
        private EcomContext context = null;
        private DbSet<T> DbSet = null;

        public GenericRepository(EcomContext _context)
        {
            context = _context;
            DbSet = context.Set<T>();
        }

        public void Add(T entity)
        {
            DbSet.Add(entity);
        }

        public void Attach(T entity)
        {
            DbSet.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            if (context.Entry(entity).State == EntityState.Detached)
            {
                DbSet.Attach(entity);
            }
            DbSet.Remove(entity);
        }

        public T Get(Func<T, bool> predicate)
        {
            return DbSet.First(predicate);
        }

        public IEnumerable<T> GetAll(Func<T, bool> predicate = null)
        {
            if (predicate != null)
            {
                return DbSet.Where(predicate);
            }

            return DbSet.AsEnumerable();
        }
    }
}
