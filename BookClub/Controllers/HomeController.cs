using Microsoft.AspNetCore.Mvc;
using BookClub.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BookClub.Controllers
{
  public class HomeController : Controller
  {

    private readonly BookClubContext _db;
    public HomeController(BookClubContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      ViewBag.BookList = _db.Books.ToList();
      ViewBag.AuthorList = _db.Authors.ToList();
      return View();
    }
  }
}