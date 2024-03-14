using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Insurance.API.Models
{
    public class Claim
    {
        [Key]
        public string UCR { get; set; }

        [ForeignKey("Id")]
        public int CompanyId { get; set; }

        public DateTime ClaimDate { get; set; }

        public DateTime LossDate { get; set; }

        public string AssuredName { get; set; }

        public float IncurredLoss { get; set; }

        public bool Closed { get; set; }
       
    }
}
