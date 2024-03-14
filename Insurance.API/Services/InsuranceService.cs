using Insurance.API.Models;
using Insurance.API.Repositories;

namespace Insurance.API.Services
{
    public class InsuranceService : IInsuranceService
    {
        private readonly IInsuranceRepository _insuranceRepository;

        public InsuranceService(IInsuranceRepository insuranceRepository)
        {
            _insuranceRepository = insuranceRepository;
        }

        public async Task<Company> GetCompanyAsync(int companyId)
        {
            return await _insuranceRepository.GetCompanyAsync(companyId);
        }

        public async Task<IEnumerable<Claim>> GetCompanyClaimsAsync(int companyId)
        {
            return await _insuranceRepository.GetCompanyClaimsAsync(companyId);
        }


        public async Task<Claim> GetClaimAsync(string claimId)
        {
            return await _insuranceRepository.GetClaimAsync(claimId);
        }

        public async Task<Claim> UpdateClaimAsync(Claim claim)
        {
            return await _insuranceRepository.UpdateClaimAsync(claim);
        }
    }
}
