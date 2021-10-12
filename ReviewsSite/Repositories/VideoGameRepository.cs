using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Repositories
{
    public class VideoGameRepository : IRepository<VideoGame>
    {
        public VideoGameContext db;

        public VideoGameRepository(VideoGameContext db)
        {
            this.db = db;
        }

        public void Create(VideoGame obj)
        {
            db.VideoGames.Add(obj);
            db.SaveChanges();
        }

        public void Delete(VideoGame obj)
        {
            throw new NotImplementedException();
        }

        public VideoGame GetByID(int id)
        {
            return db.VideoGames.Where(r => r.Id == id).FirstOrDefault();
        }

        public IEnumerable<VideoGame> GetAll()
        {
            return db.VideoGames.ToList();
        }

        public void Update(VideoGame obj)
        {
            throw new NotImplementedException();
        }
    }
}
