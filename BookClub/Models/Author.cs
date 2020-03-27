namespace BookClub.Models
{
  public class Author
  {
    public Author()
    {
      this.Books = new HashSet<AuthorBook>();
    }
    public int AuthorId {get; set;}
    public string FirstName {get;set;}
    public string LastName {get;set;}
    public virtual ICollection<AuthorBook> Books {get; set;}
  }
} 