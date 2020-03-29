using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace BookClub.Models
{
  public class Book
  {
    public int BookId { get; set; }

    public string Title { get; set; }

    [Display(Name = "Publication year")]
    public int PublicationYear { get; set; }
    public string ISBN { get; set; }
    public virtual ICollection<AuthorBook> Authors { get; set; }
    public virtual ICollection<BookGenre> Genres { get; set; }

    // make a virtual ICollection of Users here (and BOOKS in user model, plus a join table) so books can be added to a User's book list

    public Book()
    {
      this.Authors = new HashSet<AuthorBook>();
      this.Genres = new HashSet<BookGenre>();
    }
  }
}