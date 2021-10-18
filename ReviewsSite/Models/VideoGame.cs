using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Models
{
    public class VideoGame
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ReleaseDate { get; set; }
        [NotMapped]
        public double AverageRating { get; set; }
        public virtual List<Review> Reviews { get; set; }
        public virtual List<VideoGamePlatform> Platforms {get; set;}
        public string Description { get; set; }
        public string PictureURL { get; set; }
        public string VideoURL { get; set; }
        //Eventually add a picture(virtual)
        // by url add a string feild

        public void GetAverage()
        {
            if(Reviews.Count > 0)
            {
                AverageRating = Reviews.Select(r => r.Rating).Average();
            }
            else
            {
                AverageRating = 0;
            }
        }
    }



}
