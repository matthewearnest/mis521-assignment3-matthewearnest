using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyTest.Models
{
    public class Movies
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [Url]
        public string? IMBDLink { get; set; }
        public string Genre { get; set; }
        public int ReleaseYear { get; set; }
        public byte[]? MoviePoster { get; set; }

        //failed to merge tables.

       // [ForeignKey("Actors")]
       // public int? ActorId { get; set; }
       // public Movies? Actor { get; set; }
    }
}
