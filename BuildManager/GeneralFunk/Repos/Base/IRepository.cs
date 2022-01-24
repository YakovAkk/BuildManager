using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildManager.GeneralFunk.Repos.Base
{
    public interface IRepository<T> : IDisposable
    {
        List<T> GetAll();
        void Add(T item);
    }
}
