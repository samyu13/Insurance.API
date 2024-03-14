using Insurance.API.Controllers;
using Insurance.API.Models;
using Insurance.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Insurance.API.Test.System.Controllers
{
    public class TestInsuranceController
    {
        private readonly Mock<IInsuranceService> insuranceService;
        public TestInsuranceController()
        {
            insuranceService = new Mock<IInsuranceService>();
        }

        [Fact]
        public async Task GetCompanyAsync_ShouldReturn200Status()
        {
            //Arrange
            var data = MockData.MockData.Companies().Where(x => x.Id == 101).FirstOrDefault();

            insuranceService.Setup(_ => _.GetCompanyAsync(It.IsAny<int>())).ReturnsAsync(data);
            var sut = new InsuranceController(insuranceService.Object);

            //Act
            var resp = await sut.GetCompanyAsync(101);
            var okResp = resp as OkObjectResult;

            var company = okResp.Value as Company;

            //Assert
            insuranceService.Verify(m => m.GetCompanyAsync(101), Times.Once);
            Assert.True(okResp is OkObjectResult);
            Assert.Equal(StatusCodes.Status200OK, okResp.StatusCode);
            Assert.NotNull(company.Active);
        }

        [Fact]
        public async Task GetCompanyAsync_ShouldReturnBadRequest()
        {            
            var data = MockData.MockData.Companies().Where(x => x.Id == 1011).FirstOrDefault();

            insuranceService.Setup(_ => _.GetCompanyAsync(It.IsAny<int>())).ReturnsAsync(data);
            var sut = new InsuranceController(insuranceService.Object);
           
            var resp = await sut.GetCompanyAsync(1011);
            var result = resp as ObjectResult;
                      
            Assert.True(result is BadRequestObjectResult);
            Assert.Equal(StatusCodes.Status400BadRequest, result.StatusCode);
            Assert.Equal("Company with ID doesn't exist", result.Value);
        }

        [Fact]
        public async Task GetClaimsByCompanyAsync_ShouldReturnCompanyClaims()
        {
            
            var data = MockData.MockData.Claims().Where(x => x.CompanyId == 101);

            insuranceService.Setup(_ => _.GetCompanyClaimsAsync(It.IsAny<int>())).ReturnsAsync(data);
            var sut = new InsuranceController(insuranceService.Object);

            var resp = await sut.GetCompanyClaimsAsync(101);
            var okResp = resp as OkObjectResult;

            var claim = okResp.Value as IEnumerable<Claim>;

            Assert.True(resp is OkObjectResult);
            Assert.True(claim.Count() > 0);  
        }

        // more tests can be added 

    }
}
