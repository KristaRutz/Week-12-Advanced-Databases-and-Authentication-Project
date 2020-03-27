using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookClub.Models
{
  public class Author
  {
    public int AuthorId { get; set; }

    [Display(Name = "First name")]
    public string FirstName { get; set; }

    [Display(Name = "Last name")]
    public string LastName { get; set; }
    public virtual ICollection<AuthorBook> Books { get; set; }
    public virtual ICollection<AuthorGenre> Genres { get; set; }

    public Author()
    {
      this.Books = new HashSet<AuthorBook>();
      this.Genres = new HashSet<AuthorGenre>();
    }
  }
}