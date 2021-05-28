using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ChinookProject.Shared
{
    public class Genre    {
        
        public int GenreID { get; set; }
        public string Name { get; set; }
        //Related Entity
        public ICollection<Track> Tracks { get; set; }

    }

}