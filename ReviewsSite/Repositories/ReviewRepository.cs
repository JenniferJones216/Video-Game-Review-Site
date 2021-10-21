using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Repositories
{
    public class ReviewRepository : Repository<Review>
    {
        public VideoGameContext db;
        
        public ReviewRepository(VideoGameContext db) : base(db)
        {
            this.db = db;
        }
        
        public IEnumerable<Review> GetAllOrdered()
        {
            return db.Reviews.OrderBy(r => r.VideoGame.Name).ToList();
        }

        public String GetVideoGameName(int videoGameId)
        {
            return db.VideoGames.Where(r => r.Id == videoGameId).FirstOrDefault().Name;
        }

        public IEnumerable<Review> GetByGameId(int id)
        {
            //does this work?
            return db.Reviews.Where(r => r.Id == id);
        }

    }
}
