using Microsoft.AspNetCore.Identity;

namespace CasgemIdentityModel.Dal
{
    public class AppUser : IdentityUser<int>
    {
        public string NameSurname { get; set; }
    }
}
