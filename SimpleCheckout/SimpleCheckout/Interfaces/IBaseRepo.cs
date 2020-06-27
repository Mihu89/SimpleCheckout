using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCheckout.Interfaces
{
    public interface IBaseRepo<T>
    {
        int GetIdByName(T t);
        T GetById(int id);
        void Update(T t, int id);
        void Delete(T t);
        List<T> GetAll();
    }
}
