using Microsoft.AspNetCore.Mvc;
using BookClub.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;


namespace BookClub.Controllers
{
  [Authorize]
  public class GenresController : Controller
  {
    private readonly BookClubContext _db;
    public GenresController(BookClubContext db)
    {
      _db = db;
    }

    [AllowAnonymous]
    public ActionResult Index()
    {
      List<Genre> model = _db.Genres.ToList();
      return View(model);
    }

    [AllowAnonymous]
    public ActionResult Details(int id)
    {
      Genre thisGenre = _db.Genres
        .Include(g => g.Authors)
        .ThenInclude(join => join.Author)
        .Include(g => g.Books)
        .ThenInclude(join => join.Book)
        .FirstOrDefault(g => g.GenreId == id);
      return View(thisGenre);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Genre genre)
    {
      _db.Genres.Add(genre);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Edit(int id)
    {
      var thisGenre = _db.Genres.FirstOrDefault(b => b.GenreId == id);
      ViewBag.AuthorId = new SelectList(_db.Authors, "AuthorId", "Name");
      return View(thisGenre);
    }

    [HttpPost]
    public ActionResult Edit(Genre genre, int AuthorId)
    {
      if (AuthorId != 0)
      {
        _db.AuthorGenre.Add(new AuthorGenre() { AuthorId = AuthorId, GenreId = genre.GenreId });
      }
      _db.Entry(genre).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddAuthor(int id)
    {
      var thisGenre = _db.Genres.FirstOrDefault(b => b.GenreId == id);
      ViewBag.AuthorId = new SelectList(_db.Authors, "AuthorId", "Name");
      return View(thisGenre);
    }

    [HttpPost]
    public ActionResult AddAuthor(Genre genre, int AuthorId)
    {
      if (AuthorId != 0)
      {
        _db.AuthorGenre.Add(new AuthorGenre() { AuthorId = AuthorId, GenreId = genre.GenreId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddBook(int id)
    {
      var thisGenre = _db.Genres.FirstOrDefault(a => a.GenreId == id);
      ViewBag.BookId = new SelectList(_db.Books, "BookId", "Title");
      return View(thisGenre);
    }

    [HttpPost]
    public ActionResult AddBook(Genre genre, int BookId)
    {
      if (BookId != 0)
      {
        _db.BookGenre.Add(new BookGenre() { BookId = BookId, GenreId = genre.GenreId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteAuthor(int joinId)
    {
      var joinEntry = _db.AuthorGenre.FirstOrDefault(entry => entry.AuthorGenreId == joinId);
      _db.AuthorGenre.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteBook(int joinId)
    {
      var joinEntry = _db.BookGenre.FirstOrDefault(entry => entry.BookGenreId == joinId);
      _db.BookGenre.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult CheckDelete(int id)
    {
      var thisGenre = _db.Genres.FirstOrDefault(b => b.GenreId == id);
      return View("Delete", thisGenre);
    }

    [HttpPost]
    public ActionResult Delete(int id)
    {
      var thisGenre = _db.Genres.FirstOrDefault(b => b.GenreId == id);
      _db.Genres.Remove(thisGenre);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

  }
}