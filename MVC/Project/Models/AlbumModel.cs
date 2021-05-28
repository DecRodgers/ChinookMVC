using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Collections;
using ChinookProject.Shared;

namespace ChinookMVC.Models
{
    public class AlbumViewModel
    {    
        public Album viewAlbum {get; set;}      
        public Artist viewArtist {get; set;}               
    }

    public class AlbumDetailViewModel
    {    
        public Album viewAlbum {get; set;}      
        public Artist viewArtist {get; set;}               
        public Track viewTrack {get; set;}               
        public Media_Type Media_Type {get; set;} 
        public Genre Genre {get; set;} 
    }

}