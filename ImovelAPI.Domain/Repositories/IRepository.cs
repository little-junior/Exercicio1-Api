using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImovelAPI.Domain.Repositories
{
    public interface IRepository<T1, T2>
    {
        IEnumerable<T1> GetAll();
        T1 GetById(int id);
        void Add(T1 item);
        bool Delete(int id);

        bool Update(int id, T2 item);
    }
}
