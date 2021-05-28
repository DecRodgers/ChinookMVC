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
    public class ArtistController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private Chinook db;
        public ArtistController(ILogger<HomeController> logger, 
        Chinook injectedContext)
        {
            _logger = logger;
            db = injectedContext;
        }

        public IActionResult ArtistView()
        {
            var model = new ArtistViewModel
            {
                Artists = db.Artists.OrderBy(a => a.Name).ToList(),                               
            };     
            return View(model);
        }

        public IActionResult CreateArtist()
        {         
            return View();
        }

                       
        [HttpPost]        
        public IActionResult CreateArtist([Bind("Name")] Artist newArtist)
        {
            if (ModelState.IsValid)
            {
                db.Artists.Add(newArtist);
                db.SaveChanges();
                return RedirectToAction("ArtistView");        
            }            
            return View(newArtist);
        }

        public IActionResult ArtistEdit(int id){
            
            var artist = db.Artists.Where(a => a.ArtistID == id).SingleOrDefault();                
            return View(artist);
        }

        [HttpPost]
        public IActionResult ArtistEdit(Artist artistObject)        
        {
            if (ModelState.IsValid)
            {
                var artistData = db.Artists.Where(a => a.ArtistID == artistObject.ArtistID).SingleOrDefault();
                if(artistData!=null)  
                {  
                    artistData.Name = artistObject.Name;   
                    db.Artists.Update(artistData);  
                    db.SaveChanges();  
                }
                return RedirectToAction("ArtistView");
            }
            return View(artistObject);
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