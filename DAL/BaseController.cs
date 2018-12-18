using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BaseController
    {
        private static DbContext _dbContext;

        public static DbContext GetDbContext()
        {
            if (_dbContext == null)
                _dbContext = new TODOEntities();

            return _dbContext;
        }


    }
}
