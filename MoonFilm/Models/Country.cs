using System.ComponentModel.DataAnnotations;

namespace MoonFilm.Models;
public class Country
{
    [Key]
    public int CountryId { get; set; }
    public string CountryName { get; set; }
    public string CountryImage { get; set; }
    public List<Actor> Actors {get; set;}
    public List<Film> Films {get; set;}
    public List<Director> Directors { get; set; }
}