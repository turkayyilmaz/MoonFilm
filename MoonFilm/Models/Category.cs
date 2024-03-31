using System.ComponentModel.DataAnnotations;

namespace MoonFilm.Models;
public class Category
{
    [Key]
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
    public List<Film> Films { get; set; }
}