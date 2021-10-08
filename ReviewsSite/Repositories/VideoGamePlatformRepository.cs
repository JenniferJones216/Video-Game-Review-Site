using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Repositories
{
    public class VideoGamePlatformRepository : IRepository<VideoGamePlatform>
    {
        public VideoGameContext db;

        public VideoGamePlatformRepository(VideoGameContext db)
        {
            this.db = db;
        }

        public void Create(VideoGamePlatform obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(VideoGamePlatform obj)
        {
            throw new NotImplementedException();
        }

        public VideoGamePlatform GetByID(int id)
        {
            return db.VideoGamePlatforms.Where(r => r.Id == id).FirstOrDefault();
        }

        public IEnumerable<VideoGamePlatform> GetAll()
        {
            return db.VideoGamePlatforms.ToList();
        }

        public void Update(VideoGamePlatform obj)
        {
            throw new NotImplementedException();
        }
    }
}
