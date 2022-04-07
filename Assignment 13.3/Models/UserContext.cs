using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Assignment_13._3.Models
{
    public class UserContext : IdentityDbContext<User>
    {
        public UserContext
            (DbContextOptions<UserContext> options) : base(options)
        {

        }
    }
}