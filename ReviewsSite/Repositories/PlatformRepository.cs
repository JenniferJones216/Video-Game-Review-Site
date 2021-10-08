using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Repositories
{
    public class PlatformRepository : IRepository<Platform>
    {
        public VideoGameContext db;
        
        public PlatformRepository(VideoGameContext db)
        {
            this.db = db;
        }


        public void Create(Platform obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Platform obj)
        {
            throw new NotImplementedException();
        }

        public Platform GetByID(int id)
        {
            return db.Platforms.Where(r => r.Id == id).FirstOrDefault();
        }

        public IEnumerable<Platform> GetAll()
        {
            return db.Platforms.ToList();
        }

        public void Update(Platform obj)
        {
            throw new NotImplementedException();
        }
    }
}
