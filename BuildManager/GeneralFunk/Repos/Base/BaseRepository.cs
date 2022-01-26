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
        private readonly AppDBContent _db;
        public BaseRepository()
        {
            _db = new AppDBContent();
        }

        public abstract Task Add(T item);
        public abstract Task<List<T>> GetAll();
        public void Dispose()
        {
            _db.Dispose();
        }

    }
}
