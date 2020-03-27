using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookClub.Models
{
  public class BookClubContext : IdentityDbContext<ApplicationUser>
  {

  }
}