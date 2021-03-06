using Microsoft.AspNetCore.Mvc;
using BookClub.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace BookClub.Controllers
{

  [Authorize]
  public class AuthorsController : Controller
  {
    private readonly BookClubContext _db;
    public AuthorsController(BookClubContext db)
    {
      _db = db;
    }

    [AllowAnonymous]
    public ActionResult Index()
    {
      List<Author> model = _db.Authors.ToList();
      return View(model);
    }

    [AllowAnonymous]
    public ActionResult Details(int id)
    {
      Author thisAuthor = _db.Authors
        .Include(a => a.Books)
        .ThenInclude(join => join.Book)
        .Include(a => a.Genres)
        .ThenInclude(join => join.Genre)
        .FirstOrDefault(a => a.AuthorId == id);
      return View(thisAuthor);
    }
    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Author author)
    {
      _db.Authors.Add(author);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Edit(int id)
    {
      var thisAuthor = _db.Authors.FirstOrDefault(a => a.AuthorId == id);
      return View(thisAuthor);
    }

    [HttpPost]
    public ActionResult Edit(Author author)
    {
      _db.Entry(author).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddBook(int id)
    {
      var thisAuthor = _db.Authors.FirstOrDefault(a => a.AuthorId == id);
      ViewBag.BookId = new SelectList(_db.Books, "BookId", "Title");
      return View(thisAuthor);
    }

    [HttpPost]
    public ActionResult AddBook(Author author, int BookId)
    {
      if (BookId != 0)
      {
        _db.AuthorBook.Add(new AuthorBook() { BookId = BookId, AuthorId = author.AuthorId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddGenre(int id)
    {
      var thisAuthor = _db.Authors.FirstOrDefault(a => a.AuthorId == id);
      ViewBag.GenreId = new SelectList(_db.Genres, "GenreId", "Name");
      return View(thisAuthor);
    }

    [HttpPost]
    public ActionResult AddGenre(Author author, int GenreId)
    {
      if (GenreId != 0)
      {
        _db.AuthorGenre.Add(new AuthorGenre() { GenreId = GenreId, AuthorId = author.AuthorId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteBook(int joinId)
    {
      var joinEntry = _db.AuthorBook.FirstOrDefault(entry => entry.AuthorBookId == joinId);
      _db.AuthorBook.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteGenre(int joinId)
    {
      var joinEntry = _db.AuthorGenre.FirstOrDefault(entry => entry.AuthorGenreId == joinId);
      _db.AuthorGenre.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult CheckDelete(int id)
    {
      var thisAuthor = _db.Authors.FirstOrDefault(a => a.AuthorId == id);
      return View("Delete", thisAuthor);
    }

    [HttpPost]
    public ActionResult Delete(int id)
    {
      var thisAuthor = _db.Authors.FirstOrDefault(a => a.AuthorId == id);
      _db.Authors.Remove(thisAuthor);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}