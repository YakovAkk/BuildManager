using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildManager.GeneralFunk.Repos.Base
{
    public interface IRepository<T> : IDisposable
    {
        Task<List<T>> GetAll();
        Task Add(T item);
    }
}
