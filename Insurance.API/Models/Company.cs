using System.ComponentModel.DataAnnotations;

namespace Insurance.API.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
        [Required]
        public bool Active { get; set; }
        public DateTime InsuranceEndDate { get; set; }

        public IList<Claim> Claims { get; set; } = new List<Claim>();

    }
}
