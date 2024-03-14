using Insurance.API.DTO;
using Insurance.API.Models;
using Insurance.API.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Insurance.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class InsuranceController : ControllerBase
    {
        private readonly IInsuranceService _insuranceService;
        public InsuranceController(IInsuranceService insuranceService)
        {

            _insuranceService = insuranceService;
        }

        // GET api/Insurance/companies/101
        [HttpGet]
        [Route("Companies/{companyId}")]
        public async Task<ActionResult> GetCompanyAsync(int companyId)
        {
            try
            {
                var company = await _insuranceService.GetCompanyAsync(companyId);
                if (company == null)
                    return BadRequest(string.Format("Company with ID doesn't exist", companyId));
                return Ok(company);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error while retriving Company");
            }
        }

        // GET api/Insurance/companies/101/claims
        [HttpGet]
        [Route("Companies/{companyId}/Claims")]
        public async Task<ActionResult> GetCompanyClaimsAsync(int companyId)
        {
            try
            {
                return Ok(await _insuranceService.GetCompanyClaimsAsync(companyId));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error while retriving Claims");
            }
        }

        // GET api/Insurance/claims/CLM11
        [HttpGet]
        [Route("Claims/{claimId}")]
        public async Task<ActionResult> GetClaimAsync(string claimId)
        {
            try
            {
                var claim = await _insuranceService.GetClaimAsync(claimId);

                if (claim == null)
                    return NotFound($"Claim with Id = {claimId} not found");

                var dto = new ClaimDTO();
                var claimDto = dto.ToClaimDTO(claim); 

                claimDto.ClaimAgeInDays = (System.DateTime.Now.Date - claim.ClaimDate).Days;
                return Ok(claimDto);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error while retriving claim");
            }
        }


        [HttpPut("Claims/{claimId}")]
        public async Task<ActionResult<Claim>> UpdateClaimAsync(string claimId, Claim claim)
        {
            try
            {
                if (claimId != claim.UCR)
                    return BadRequest(string.Format("Claim ID mismatch", claimId));

                var c = await _insuranceService.GetClaimAsync(claimId);

                if (c == null)
                    return NotFound($"Claim with Id = {claimId} not found");

                return Ok(await _insuranceService.UpdateClaimAsync(claim));

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error while updating claim");
            }
        }
    }
}
