using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace BookClub.Models
{
  public class Book
  {
    public int BookId { get; set; }

    [Required]
    public string Title { get; set; }

    [Display(Name = "Publication year")]
    public DateTime PublicationYear { get; set; }
    public string ISBN { get; set; }
    public virtual ICollection<AuthorBook> Authors { get; set; }
    public virtual ICollection<BookGenre> Genres { get; set; }

    public Book()
    {
      this.Authors = new HashSet<AuthorBook>();
      this.Genres = new HashSet<BookGenre>();
    }
  }
}