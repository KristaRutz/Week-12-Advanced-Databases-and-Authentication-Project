using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookClub.Models
{
  public class BookClubContext : IdentityDbContext<ApplicationUser>
  {
    public virtual DbSet<Book> Books {get;set;}
    public virtual DbSet<Author> Authors {get;set;}
    public virtual DbSet<Genre> Genres {get;set;}
    public DbSet<BookGenre> BookGenre {get;set;}
    public DbSet<AuthorBook> AuthorBook {get;set;}
    public DbSet<AuthorGenre> AuthorGenre {get;set;}

    public BookClubContext(DbContextOptions options) : base(options){}
  }
}