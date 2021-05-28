using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ChinookProject.Shared
{
    public class Album
    {
        public int AlbumID { get; set; }
        [Required(ErrorMessage="Album Title is Required.")]
        [Display(Name="Album Title")]
        [MinLength(1)]
        public string Title { get; set; }
        [Required(ErrorMessage="Album Artist is Required.")]
        [Display(Name="Artist Album")]
        public int ArtistID { get; set; }
        //Related Entities
        public Artist Artist { get; set; }
        public ICollection<Track> Tracks { get; set; }
    }
}