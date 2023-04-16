using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BloodDonorManagementSystem.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<BloodDonor>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
            public DbSet<BloodType> BloodTypes { get; set; }
        public DbSet<BloodProductsAllocation> BloodProductsAllocations { get; set; }
    }
}