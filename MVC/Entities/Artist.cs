using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ChinookProject.Shared
{
    public class Artist
    {
        public int ArtistID { get; set; }        
        [Required(ErrorMessage="Artist name is Required.")]
        [Display(Name="Artist Name")]
        [MinLength(1)]
        public string Name { get; set; }
        //Related Entity
        public ICollection<Album> Albums {get; set;}
    }
}
