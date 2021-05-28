using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ChinookProject.Shared
{
        public class Media_Type
    {
        [Key]
        public int MediaTypeID { get; set; }
        public string Name { get; set; }
        //Related Entity
        public ICollection<Track> Tracks { get; set; }
    }
}