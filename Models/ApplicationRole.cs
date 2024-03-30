using Microsoft.AspNetCore.Identity;

namespace DemoDeploy.Models
{
    public class ApplicationRole : IdentityRole<int>
    {
        public DateTime CreatedOn { get; set; }
        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}
