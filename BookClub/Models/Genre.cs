namespace BookClub.Models
{
  public class Genre
  {
    public int GenreId {get; set;}
    public string Name {get; set;}
    public virtual ICollection<AuthorGenre> Authors {get; set;}
    public virtual ICollection<BookGenre> Books {get;set;}

    public Genre()
    {
      this.Authors = new HashSet<AuthorGenre>();
      this.Books = new HashSet<BookGenre>();
    }
  }
}