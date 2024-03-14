using Insurance.API.Models;

namespace Insurance.API.Services
{
    public interface IInsuranceService
    {
        Task<Company> GetCompanyAsync(int companyId);

        Task<IEnumerable<Claim>> GetCompanyClaimsAsync(int companyId);

        Task<Claim> GetClaimAsync(string claimId);

        Task<Claim> UpdateClaimAsync(Claim claim);
    }
}
