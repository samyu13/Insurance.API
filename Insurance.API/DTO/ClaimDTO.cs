using Insurance.API.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Insurance.API.DTO
{
    public  class ClaimDTO
    {
        public string UCR { get; set; }
       
        public int CompanyId { get; set; }

        public DateTime ClaimDate { get; set; }

        public DateTime LossDate { get; set; }

        public string AssuredName { get; set; }

        public float IncurredLoss { get; set; }

        public bool Closed { get; set; }

        public int ClaimAgeInDays { get; set; }

        public ClaimDTO ToClaimDTO(Claim claim)
        {
            return new ClaimDTO()
            {
                UCR = claim.UCR,
                CompanyId = claim.CompanyId,
                ClaimDate = claim.ClaimDate,
                LossDate = claim.LossDate,
                AssuredName = claim.AssuredName,
                IncurredLoss = claim.IncurredLoss,
                Closed = claim.Closed                 
            };

        }

    }
    
}
