using Microsoft.AspNetCore.Identity;
namespace BloodDonorManagementSystem.Web.Data
{
    public class BloodDonor : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set;}
        public string? DonorId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateVisited { get; set; }

    }
}
