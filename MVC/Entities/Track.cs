using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ChinookProject.Shared
{
    public class Track
    {
        public int TrackID { get; set; }
        [Required(ErrorMessage="Track Title is Required.")]
        [Display(Name="Track Title")]
        [MinLength(1)]
        public string Name { get; set; } 
        [Required(ErrorMessage="Media Type is Required.")]
        [Display(Name="Media Type")]              
        public int MediaTypeID { get; set; }
        [Required(ErrorMessage="Track Genre is Required.")]
        [Display(Name="Genre")]    
        public int GenreID { get; set; }
        [Required(ErrorMessage="Track Length Required.")]
        [Display(Name="Track Length (in Milliseconds)")]
        public int Milliseconds { get; set; }
        [Required(ErrorMessage="Track Price Required.")]
        [Display(Name="Track Cost")]
        public double UnitPrice  { get; set; }
        public int AlbumID {get; set;}
        //Related Entities
        public Album Album { get; set; }              
        public Media_Type Media_Type { get; set; } 
        public Genre Genre { get; set; }            

    }
}