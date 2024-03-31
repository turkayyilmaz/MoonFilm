using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoonFilm.Models;
public class Director
{
    [Key]
    public int DirectorId { get; set; }
    public string DirectorFullName { get; set; }
    public string DirectorDescription { get; set; }
    public DateTime DateTime { get; set; }
    public string DirectorImage { get; set;}
    [ForeignKey(nameof(Country))]
    public int CountryId { get; set; }
    public Country Country { get; set; }
    public List<Film> Films {get; set;} 
}