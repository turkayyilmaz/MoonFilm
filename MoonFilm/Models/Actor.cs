using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoonFilm.Models;
public class Actor
{
    [Key]
    public int ActorId { get; set; }
    public string ActorFullName { get; set; }
    public string ActorDescription { get; set; }
    public DateTime DateTime { get; set; }
    public string ImageUrl { get; set; }
    [ForeignKey(nameof(Country))]
    public int CountryId { get; set; }
    public Country Country { get; set; }
    public List<Film> Films { get; set; }

}