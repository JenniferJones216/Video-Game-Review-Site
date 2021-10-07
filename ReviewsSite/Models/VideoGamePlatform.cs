using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite
{
    public class VideoGamePlatform
    {
        public int Id { get; set; }
        public int VideoGameId { get; set; }
        public virtual VideoGame VideoGame { get; set; }
        public int PlatformId { get; set; }
        public virtual Platform Platform { get; set; }
    }
}
