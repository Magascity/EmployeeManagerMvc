using Microsoft.AspNetCore.Identity;

namespace EmployeeManagerMvc.Security
{
    public class AppIdentityRole : IdentityRole
    {
        public string Description { get; set; } = string.Empty;

    }
}
