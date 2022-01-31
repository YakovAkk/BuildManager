using BuildManager.Data.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildManager.GeneralFunk.Repos.Base
{
    public abstract class BaseRepository<T> : IRepository<T>
    {
        protected readonly AppDBContent _db;
        public BaseRepository()
        {
            _db = new AppDBContent();
        }

        public abstract void Add(T item);
        public abstract List<T> GetAll();
        public void Dispose()
        {
            _db.Dispose();
        }

       
    
    }
}
