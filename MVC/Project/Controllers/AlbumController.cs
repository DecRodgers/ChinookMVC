using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using ChinookMVC.Models;
using ChinookProject.Shared;

namespace ChinookMVC.Controllers
{
    public class AlbumController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private Chinook db;
        public AlbumController(ILogger<HomeController> logger, 
        Chinook injectedContext)
        {
            _logger = logger;
            db = injectedContext;
        }

        public IActionResult AlbumView()
        {
            var model = from a in db.Albums
                        join o in db.Artists on a.ArtistID equals o.ArtistID
                        orderby a.Title, o.Name
                        select new AlbumViewModel
                        {
                            viewAlbum = a, viewArtist = o
                        };
            return View(model);
        }



        [HttpPost]
        public IActionResult DeleteSelectedAlbum(int id)
        {
            using(db)
            {
                var albumData = db.Albums.Where(al => al.AlbumID == id).FirstOrDefault();
                db.Albums.Remove(albumData);
                db.SaveChanges();                
            }
            return Json(new { status = "Success" });            
        }

        public IActionResult AlbumDetail(int? id)
        {
            ViewBag.id = id;
            if (!id.HasValue)
            {
                return NotFound("Album not found" );
            }            
            var albumDetails = from a in db.Albums
                               join o in db.Artists on a.ArtistID equals o.ArtistID
                               join t in db.Tracks on a.AlbumID equals t.AlbumID
                               join m in db.Media_Types on t.MediaTypeID equals m.MediaTypeID
                               join g in db.Genres on t.GenreID equals g.GenreID
                               where a.AlbumID == id
                               orderby a.Title, o.Name, t.Name, m.Name, g.Name
                               select new AlbumDetailViewModel
                               {
                                   viewAlbum = a,
                                   viewArtist = o,
                                   viewTrack = t,
                                   Media_Type = m,
                                   Genre = g
                               };
            if (albumDetails == null)
            {
                return NotFound("Album not found #2");
            }
            return View(albumDetails);
        }

        public IActionResult CreateAlbum()
        {         
            var ArtistList = db.Artists.ToList();                      
            ViewBag.artistList = ArtistList;
            return View();
        }

                
        [HttpPost]        
        public IActionResult CreateAlbum(Album newAlbum)
        {
            if (ModelState.IsValid)
            {
                db.Albums.Add(newAlbum);
                db.SaveChanges();
                return RedirectToAction("AlbumView");        
            }
            var ArtistList = db.Artists.ToList();                      
            ViewBag.artistList = ArtistList;            
            return View(newAlbum);
        }

        public IActionResult AlbumEdit(int id)
        {
            var album = db.Albums.Where(a => a.AlbumID == id).SingleOrDefault();
            var ArtistList = db.Artists.ToList();                      
            ViewBag.artistList = ArtistList;
            ViewBag.AlbumID = id;
            return View(album);
        }

        [HttpPost]        
        public IActionResult AlbumEdit(int id,Album albumObject)
        {
            var ArtistList = db.Artists.ToList();                      
            ViewBag.artistList = ArtistList;
            ViewBag.AlbumID = id;            
            if (ModelState.IsValid)
            {                
                var albumData = db.Albums.Where(a => a.AlbumID == id).FirstOrDefault();                
                if(albumData!=null)  
                { 
                    albumData.Title = albumObject.Title;
                    albumData.ArtistID = albumObject.ArtistID;                                
                    db.Albums.Update(albumData);                
                    db.SaveChanges();                  
                    return RedirectToAction("AlbumView");
                }
             }                           
            return View(albumObject);
        }

        public IActionResult CreateTrack(int id)
        {
            var newTrack = new Track();
            var media_TypeList = db.Media_Types.ToList();                                             
            ViewBag.Media_TypeList = media_TypeList;
            var genreList = db.Genres.ToList(); 
            ViewBag.GenreList = genreList;
            ViewBag.albumID = id;            
            newTrack.AlbumID = id;
            return View(newTrack);
        }

        [HttpPost]  
        public IActionResult CreateTrack(int id,Track newTrack)
        {
            var media_TypeList = db.Media_Types.ToList();                      
            ViewBag.Media_TypeList = media_TypeList;
            var genreList = db.Genres.ToList(); 
            ViewBag.GenreList = genreList;
            if (ModelState.IsValid)
            {
                newTrack.AlbumID = id;
                db.Tracks.Add(newTrack);
                db.SaveChanges();
                return RedirectToAction("AlbumDetail", new {id});        
            }                        
            return View(newTrack);
        }

        //had to pass albumid to eliminate track orphaning issue 
        //where albumid value defaulted to 0 and redfirect back did not work
        public IActionResult TrackEdit(int id, int albumid)
        {            
            var trackObject = db.Tracks.Where(a => a.TrackID == id).SingleOrDefault();            
            var media_TypeList = db.Media_Types.ToList();                      
            ViewBag.Media_TypeList = media_TypeList;
            var genreList = db.Genres.ToList(); 
            ViewBag.GenreList = genreList;
            ViewBag.TrackID = id;
            ViewBag.AlbumID = trackObject.AlbumID;            
            trackObject.AlbumID = id;
            return View(trackObject);
        }

        [HttpPost]  
        public IActionResult TrackEdit(int id,int albumid,Track trackObject)
        {
            ViewBag.TrackID = id;
            ViewBag.AlbumID = albumid;
            var media_TypeList = db.Media_Types.ToList();                      
            ViewBag.Media_TypeList = media_TypeList;
            var genreList = db.Genres.ToList(); 
            ViewBag.GenreList = genreList;
            if (ModelState.IsValid)
            {  
                var trackData = db.Tracks.Where(tr => tr.TrackID == id).FirstOrDefault();                
                if(trackData!=null)  
                { 
                    trackData.Name = trackObject.Name;
                    trackData.MediaTypeID = trackObject.MediaTypeID;
                    trackData.GenreID = trackObject.GenreID;
                    trackData.Milliseconds = trackObject.Milliseconds;
                    trackData.UnitPrice = trackObject.UnitPrice;             
                    trackData.AlbumID = ViewBag.AlbumID;
                    db.Tracks.Update(trackData);
                    db.SaveChanges();                    
                }
                return RedirectToAction("AlbumDetail", new {id = albumid});                            
            }                        
            return View(trackObject);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}