using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoonFilm.Models;

namespace MoonFilm.Controllers;
public class DefaultController : Controller
{
    private readonly MoonFilmDbContext _moon;
    public DefaultController(MoonFilmDbContext moon)
    {
        _moon = moon;
    }
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Actor()
    {
        List<Actor> values = _moon.Actors.Include(x => x.Country).ToList();
        return View(values);
    }
    public IActionResult ActorDetail(int? id)
    {
        List<Actor> values = _moon.Actors.Include(x => x.Country).Include(x => x.Films).ToList();
        if (id != null)
        {
            var detail = values.FirstOrDefault(x => x.ActorId == id);
            if (detail != null)
            {
                ViewBag.Films = detail.Films;
                return View(detail);
            }
            return RedirectToAction("NotFoundItem", "Default");
        }
        return RedirectToAction("Actor", "Default");
    }
    public IActionResult Country()
    {
        List<Country> values = _moon.Countries.Include(x => x.Actors).ToList();
        return View(values);
    }
    public IActionResult Country_Actors(int? id)
    {
        List<Actor> values = _moon.Actors.Include(x => x.Country).ToList();
        if (id != null)
        {
            var detail = values.Where(x => x.CountryId == id).ToList(); //liste gönderiyoruz
            if (detail != null)
            {
                return View(detail);
            }
            return RedirectToAction("NotFoundItem", "Default");
        }
        return RedirectToAction("Country", "Default");
    }
    public IActionResult Film()
    {
        List<Film> films = _moon.Films.Include(x => x.Country).Include(x => x.Categories).ToList();
        return View(films);
    }
   
    public IActionResult Country_Films(int? id)
    {
        List<Film> values = _moon.Films.Include(x => x.Country).ToList();
        if (id != null)
        {
            var detail = values.Where(x => x.CID == id).ToList();
            if (detail != null)
            {
                return View(detail);
            }
            return RedirectToAction("NotFoundItem", "Default");
        }
        return RedirectToAction("Country", "Default");
    }
    public IActionResult Director()
    {
        List<Director> directors = _moon.Directors.Include(x => x.Country).ToList();
        return View(directors);
    }
    public IActionResult DirectorDetail(int? id)
    {
        List<Director> directors = _moon.Directors.Include(x => x.Country).Include(x => x.Films).ToList();
        if (id != null)
        {
            var detail = directors.FirstOrDefault(x => x.DirectorId == id);
            if (detail != null)
            {
                ViewBag.Films = detail.Films;
                return View(detail);
            }
            return RedirectToAction("NotFoundItem", "Default");
        }
        return RedirectToAction("Director", "Default");
    }
    public IActionResult Country_Directors(int? id)
    {
        List<Director> values = _moon.Directors.Include(x => x.Country).ToList();
        if (id != null)
        {
            var detail = values.Where(x => x.CountryId == id).ToList();
            if (detail != null)
            {
                return View(detail);
            }
            return RedirectToAction("NotFoundItem", "Default");
        }
        return RedirectToAction("Country", "Default");
    }
    public IActionResult FilmDetail(int? id)
    {
        List<Film> values = _moon.Films.Include(x => x.Country).Include(x => x.Actors).Include(x => x.Director).Include(x => x.Categories).ToList();
        if (id != null)
        {
            var detail = values.FirstOrDefault(x => x.FilmId == id);
            if (detail != null)
            {
                ViewBag.Films = detail.Actors;
                return View(detail);
            }
            return RedirectToAction("NotFoundItem", "Default");
        }
        return RedirectToAction("Actor", "Default");
    }
    public IActionResult NotFoundItem()
    {
        return View();
    }
    
}