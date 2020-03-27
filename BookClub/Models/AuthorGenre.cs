namespace BookClub.Models
{
  public class AuthorGenre
  {
    public int AuthorGenreId {get; set;}
    public int AuthorId {get; set;}
    public int GenreId {get; set;}
    public Author Author {get; set;}
    public Genre Genre {get; set;}
  }
}