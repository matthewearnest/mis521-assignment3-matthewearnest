using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyTest.Models
{
    public class Actors
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        [Url]
        public string? IMBDLink { get; set; }
        public byte[]? ActorPhoto { get; set; }



        //failed to merge tables.

        [ForeignKey("Movies")]
        public int? MovieId { get; set; }
        public Movies? Movie { get; set; }
    }
}
