using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Repositories
{
    public class ReviewRepository : IRepository<Review>
    {
        public VideoGameContext db;
        
        public ReviewRepository(VideoGameContext db)
        {
            this.db = db;
        }
        
        public void Create(Review obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Review obj)
        {
            throw new NotImplementedException();
        }

        public Review GetByID(int id)
        {
            return db.Reviews.Where(r => r.Id == id).FirstOrDefault();
        }

        public IEnumerable<Review> GetByGameID(int gameid)
        {
            return db.Reviews.Where(r => r.VideoGameId == gameid);
        }
        public IEnumerable<Review> GetAll()
        {
            return db.Reviews.ToList();
        }

        public String GetVideoGameName(int videoGameId)
        {
            return db.VideoGames.Where(r => r.Id == videoGameId).FirstOrDefault().Name;
        }

        public void Update(Review obj)
        {
            throw new NotImplementedException();
        }
    }
}
