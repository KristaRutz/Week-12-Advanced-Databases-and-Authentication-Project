using Microsoft.AspNetCore.Mvc;
using BookClub.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BookClub.Controllers
{
  public class AuthorsController : Controller
  {
    private readonly BookClubContext _db;
    public AuthorsController(BookClubContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Author> model = _db.Authors.ToList();
      return View(model);
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
  }
}