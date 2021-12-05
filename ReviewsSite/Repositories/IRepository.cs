using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Repositories
{
    public interface IRepository<T> where T : BaseModel
    {
        //c
        void Create(T obj);

        //r
        IEnumerable<T> GetAll();
        T GetByID(int id);
        //u
        void Update(T obj);
        //d 
        void Delete(T obj);

    }
}
