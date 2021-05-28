using System.IO;
using Microsoft.EntityFrameworkCore;
using System;

namespace ChinookProject.Shared
{
    public class Chinook : DbContext
    {
    public DbSet<Album> Albums { get; set; }
    public DbSet<Track> Tracks { get; set; }
    public DbSet<Artist> Artists { get; set; }
    public DbSet<Media_Type> Media_Types { get; set; }
    public DbSet <Genre> Genres { get; set; }
    public Chinook(DbContextOptions<Chinook> options)
    : base(options) { }    
    protected override void OnConfiguring(DbContextOptionsBuilder DbContextOptionsBuilder)        
    {
        string pathDb = Path.Combine("..", "chinook.db");            
        DbContextOptionsBuilder.UseSqlite($"Filename={pathDb};Foreign Keys=False");            
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Artist>()
            .HasMany(a => a.Albums)
            .WithOne(o => o.Artist);
            //Track FKs                        
            modelBuilder.Entity<Track>()
            .HasOne(g => g.Genre)
            .WithMany(t => t.Tracks)
            .HasForeignKey(t => t.GenreID)
            .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Track>()
            .HasOne(al => al.Album)
            .WithMany(t => t.Tracks)
            .HasForeignKey(t => t.AlbumID)
            .OnDelete(DeleteBehavior.NoAction);  
            modelBuilder.Entity<Track>()
            .HasOne(m => m.Media_Type)
            .WithMany(t => t.Tracks)
            .HasForeignKey(m => m.MediaTypeID)
            .OnDelete(DeleteBehavior.NoAction);
            //Album FK                              
            modelBuilder.Entity<Album>()
            .HasOne(o => o.Artist)
            .WithMany(a => a.Albums)
            .HasForeignKey(o => o.ArtistID)
            .OnDelete(DeleteBehavior.NoAction);                   
        }
    }
}
