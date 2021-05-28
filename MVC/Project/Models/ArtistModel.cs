using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Collections;
using ChinookProject.Shared;

namespace ChinookMVC.Models
{
   public class ArtistViewModel
    {
        public IList<Artist> Artists {get; set;}                                         
    }   
}