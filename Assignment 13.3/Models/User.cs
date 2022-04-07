using Microsoft.AspNetCore.Identity;

namespace Assignment_13._3.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }   
    }
}
