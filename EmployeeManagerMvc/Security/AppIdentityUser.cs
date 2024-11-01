using Microsoft.AspNetCore.Identity;

namespace EmployeeManagerMvc.Security
{
    public class AppIdentityUser : IdentityUser
    {
        public string FullName { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
    }
}
