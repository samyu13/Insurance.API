using Insurance.API.Controllers;
using Insurance.API.Models;
using Insurance.API.Repositories;
using Insurance.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.API.Test.System.Services
{
    public class InsuranceServiceTest
    {
        private readonly Mock<IInsuranceRepository> insuranceRepository;
        public InsuranceServiceTest()
        { 
            insuranceRepository = new Mock<IInsuranceRepository>();
        }

        [Fact]
        public async Task GetCompanyAsync_ShouldReturnCompanyData()
        {
            var data = MockData.MockData.Companies().Where(x => x.Id == 101).FirstOrDefault();

            insuranceRepository.Setup(_ => _.GetCompanyAsync(It.IsAny<int>())).ReturnsAsync(data);

            var sut = new InsuranceService(insuranceRepository.Object);
           
            var resp = await sut.GetCompanyAsync(101);

            Assert.NotNull(resp);
            insuranceRepository.Verify(m => m.GetCompanyAsync(101), Times.Once);
        }


        [Fact]
        public async Task GetCompanyClaimsAsync_ShouldReturnCompanyClaims()
        {
            var data = MockData.MockData.Claims().Where(x => x.CompanyId == 101);

            insuranceRepository.Setup(_ => _.GetCompanyClaimsAsync(It.IsAny<int>())).ReturnsAsync(data);

            var sut = new InsuranceService(insuranceRepository.Object);

            var resp = await sut.GetCompanyClaimsAsync(101);

            Assert.NotNull(resp);
            insuranceRepository.Verify(m => m.GetCompanyClaimsAsync(101), Times.Once);
        }

        // More tests can be added
    }
}
