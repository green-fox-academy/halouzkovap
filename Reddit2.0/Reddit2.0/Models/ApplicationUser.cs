using Microsoft.AspNetCore.Identity;

namespace Reddit2._0.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Surname { get; set; }
        public string NickName { get; set; }
        public string FullName { get; set; }
    }
}
