using Microsoft.EntityFrameworkCore;
using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseModel
    {
        protected readonly VideoGameContext db;
        private DbSet<T> entities;
        public Repository(VideoGameContext db)
        {
            this.db = db;
            entities = db.Set<T>();
        }
        public void Create(T obj)
        {
            entities.Add(obj);
            db.SaveChanges();
        }

        public void Delete(T obj)
        {
            entities.Remove(obj);
            db.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return entities.ToList();
        }

        public T GetByID(int id)
        {
            return entities.Where(r => r.Id == id).FirstOrDefault();
        }

        public void Update(T obj)
        {
            entities.Update(obj);
            db.SaveChanges();
        }
    }
}
