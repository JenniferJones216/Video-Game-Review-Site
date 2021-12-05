using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Models
{
    public class VideoGame : BaseModel
    {
        public string Name { get; set; }
        public string ReleaseDate { get; set; }
        [NotMapped]
        public double AverageRating { get; set; }
        public virtual List<Review> Reviews { get; set; }
        public virtual List<VideoGamePlatform> Platforms {get; set;}
        public string Description { get; set; }
        public string PictureURL { get; set; }
        public string VideoURL { get; set; }

        public void SetAverage()
        {
            if(Reviews.Count > 0)
            {
                AverageRating = Math.Round(Reviews.Select(r => r.Rating).Average(),2,MidpointRounding.AwayFromZero);
            }
            else
            {
                AverageRating = 0;
            }
        }
    }



}
