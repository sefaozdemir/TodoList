using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Repository<T> : BaseController where T : class
    {
        private static DbContext dbContext;
        public Repository()
        {
           dbContext= BaseController.GetDbContext();
        }

        public void Insert(T entity)
        {
            dbContext.Set<T>().Add(entity);
            dbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            dbContext.Entry(entity).State = EntityState.Modified;
            dbContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            dbContext.Set<T>().Remove(entity);
            dbContext.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {            
            return dbContext.Set<T>().AsEnumerable();
        }
    }
}
