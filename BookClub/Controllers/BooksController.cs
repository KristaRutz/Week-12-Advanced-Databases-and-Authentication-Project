using Microsoft.AspNetCore.Mvc;
using BookClub.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BookClub.Controllers
{
  public class BooksController : Controller
  {
    private readonly BookClubContext _db;
    public BooksController(BookClubContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Book> model = _db.Books.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Book book)
    {
      _db.Books.Add(book);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}