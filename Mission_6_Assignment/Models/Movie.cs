using System.ComponentModel.DataAnnotations;

namespace Mission_6_Assignment.Models
{
    public class Movie
    {
        [Key]
        public int MovieID { get; set; }
        public string MovieCategory { get; set; }
        public string MovieTitle { get; set; }
        public int MovieYear { get; set; }
        public string MovieDirector { get; set; }
        public string MovieRating { get; set; }
        public bool MovieEdited { get; set; }
        public string MovieLentTo { get; set; }
        public string MovieNotes { get; set; }
    }
}
