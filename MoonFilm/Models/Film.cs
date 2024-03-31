using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MoonFilm.Models;
public class Film
{
    [Key]
    public int FilmId { get; set; }
    public string FilmName { get; set; }
    public short Year { get; set; }
    public float IMDb { get; set; }
    public string Url { get; set; }
    public string CoverImageUrl { get; set; }
    public string Description { get; set; }
    public List<Actor> Actors { get; set; }
    [ForeignKey(nameof(Country))]
    public int CID { get; set; }
    public Country Country { get; set; }
    [ForeignKey(nameof(Director))]
    public int DID { get; set; }
    public Director Director { get; set; }
    public List<Category> Categories { get; set; }
}