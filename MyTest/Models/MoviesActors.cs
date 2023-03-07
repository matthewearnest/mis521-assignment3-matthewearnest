using System.ComponentModel.DataAnnotations.Schema;

namespace MyTest.Models
{
    public class MoviesActors
    {
        public int MoviesActorsId { get; set; }
        [ForeignKey("Movies")]
        public int? MovieID { get; set; }
        public Movies? Movie { get; set; }
        [ForeignKey("Actors")]
        public int? ActorID { get; set; }
        public Actors? Actor { get; set; }
    }
}
