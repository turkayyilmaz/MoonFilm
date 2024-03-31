using System.IO.Compression;
using Microsoft.EntityFrameworkCore;

namespace MoonFilm.Models;
public class MoonFilmDbContext : DbContext
{
    public MoonFilmDbContext(DbContextOptions<MoonFilmDbContext> options) : base(options)
    {

    }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Actor> Actors { get; set; }
    public DbSet<Film> Films { get; set; }
    public DbSet<Director> Directors { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Actor>()
                    .HasOne(x => x.Country)
                    .WithMany(x => x.Actors)
                    .HasForeignKey(x => x.CountryId)
                    .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Film>()
                    .HasOne(x => x.Country)
                    .WithMany(x => x.Films)
                    .HasForeignKey(x => x.CID)
                    .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Director>()
                    .HasOne(x => x.Country)
                    .WithMany(x => x.Directors)
                    .HasForeignKey(x => x.CountryId)
                    .OnDelete(DeleteBehavior.Restrict);             
        modelBuilder.Entity<Film>()
                    .HasOne(x => x.Director)
                    .WithMany(x => x.Films)
                    .HasForeignKey(x => x.DID)
                    .OnDelete(DeleteBehavior.Restrict);                   
        modelBuilder.Entity<Actor>()
                    .HasMany(x => x.Films)
                    .WithMany(x => x.Actors)
                    .UsingEntity(x => x.ToTable("ActorFilms"));
        modelBuilder.Entity<Category>()
                    .HasMany(x => x.Films)
                    .WithMany(x => x.Categories)
                    .UsingEntity(x => x.ToTable("CategoryFilms"));            
    }

    
    
}