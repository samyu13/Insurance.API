using Insurance.API.Models;

namespace Insurance.API.Repositories
{
    public interface IInsuranceRepository
    {
        Task<Company> GetCompanyAsync(int companyId);

        Task<IEnumerable<Claim>> GetCompanyClaimsAsync(int companyId);

        Task<Claim> GetClaimAsync(string claimId);

        Task<Claim> UpdateClaimAsync(Claim claim);
    }
}
