namespace BookClub.Models
{
  public class BookGenre
  {
    public int BookGenreId {get; set;}
    public int BookId {get; set;}
    public int GenreId {get; set;}
    public Book Book {get; set;}
    public Genre Genre {get; set;}
  }
}