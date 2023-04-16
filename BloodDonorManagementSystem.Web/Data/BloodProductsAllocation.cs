using System.ComponentModel.DataAnnotations.Schema;

namespace BloodDonorManagementSystem.Web.Data
{
    public class BloodProductsAllocation : BaseEntity 
    {
        public int NumberOfDays { get; set; }


        [ForeignKey("BloodTypeId")]   
        public BloodType? BloodType { get; set; }

        public string? BloodDonorId { get; set; }

        public int BloodTypeId { get; set; }
       
    }
}
