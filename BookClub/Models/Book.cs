using System;

namespace BookClub.Models
{
  public class Book
  {
    public int BookId {get;set;}
    public string Title {get;set;}
    public int PublicationYear {get;set;}
    public virtual ICollection<AuthorBook> Authors {get;set;}
    public virtual ICollection<BookGenre> Genres {get;set;}

    public Book()
    {
      this.Authors = new HashSet<AuthorBook>();
      this.Genres = new HashSet<BookGenre>();
    }
  }
}