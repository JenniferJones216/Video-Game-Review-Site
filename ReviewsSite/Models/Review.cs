using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Models
{
    public class Review : BaseModel
    {
        public double Rating { get; set; }
        public string Usercomment { get; set; }
        public string Username { get; set; }
        public int VideoGameId { get; set; }
        public virtual VideoGame VideoGame { get; set; }
    }
}
