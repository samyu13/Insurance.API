﻿using Insurance.API.Models;

namespace Insurance.API.Test.MockData
{
    internal class MockData
    {
        public static List<Company> Companies()
        {
            var companies = new List<Company>();
            companies.Add(new Company { Id = 101, Name = "Microsoft", Address1 = "Leeds", Address2 = "", Address3 = "", Postcode = "", Country = "", Active = true, InsuranceEndDate = DateTime.Now.AddDays(90) });

            companies.Add(new Company { Id = 102, Name = "Google", Address1 = "Huddersfield", Address2 = "", Address3 = "", Postcode = "", Country = "", Active = true, InsuranceEndDate = DateTime.Now.AddDays(120) });

            companies.Add(new Company { Id = 103, Name = "Facebook", Address1 = "Manchester", Address2 = "", Address3 = "", Postcode = "", Country = "", Active = true, InsuranceEndDate = DateTime.Now.AddDays(50) });

            companies.Add(new Company { Id = 104, Name = "BBC", Address1 = "London", Address2 = "", Address3 = "", Postcode = "", Country = "", Active = true, InsuranceEndDate = DateTime.Now.AddDays(70) });

            companies.Add(new Company { Id = 105, Name = "Facebook", Address1 = "Wakefield", Address2 = "", Address3 = "", Postcode = "", Country = "", Active = false, InsuranceEndDate = DateTime.Now.AddDays(110) });

            companies.Add(new Company { Id = 106, Name = "Linkedin", Address1 = "Hull", Address2 = "", Address3 = "", Postcode = "", Country = "", Active = true, InsuranceEndDate = DateTime.Now.AddDays(80) });

            companies.Add(new Company { Id = 107, Name = "Twitter", Address1 = "Sheffield", Address2 = "", Address3 = "", Postcode = "", Country = "", Active = true, InsuranceEndDate = DateTime.Now.AddDays(100) });

            return companies;

        }

        public static List<Claim> Claims()
        {
            var claims = new List<Claim>();

            claims.Add(new Claim { UCR = "CLM11", CompanyId = 101, ClaimDate = DateTime.Now.AddDays(-30), LossDate = DateTime.Now.AddDays(60), AssuredName = "test", IncurredLoss = 100, Closed = false });

            claims.Add(new Claim { UCR = "CLM12", CompanyId = 101, ClaimDate = DateTime.Now.AddDays(-13), LossDate = DateTime.Now.AddDays(60), AssuredName = "", IncurredLoss = 100, Closed = false });

            claims.Add(new Claim { UCR = "CLM13", CompanyId = 102, ClaimDate = DateTime.Now.AddDays(-30), LossDate = DateTime.Now.AddDays(60), AssuredName = "", IncurredLoss = 100, Closed = false });

            claims.Add(new Claim { UCR = "CLM114", CompanyId = 103, ClaimDate = DateTime.Now.AddDays(-30), LossDate = DateTime.Now.AddDays(60), AssuredName = "", IncurredLoss = 100, Closed = false });

            claims.Add(new Claim { UCR = "CLM15", CompanyId = 105, ClaimDate = DateTime.Now.AddDays(-30), LossDate = DateTime.Now.AddDays(60), AssuredName = "", IncurredLoss = 100, Closed = false });

            claims.Add(new Claim { UCR = "CLM16", CompanyId = 105, ClaimDate = DateTime.Now.AddDays(-30), LossDate = DateTime.Now.AddDays(60), AssuredName = "", IncurredLoss = 100, Closed = false });

            claims.Add(new Claim { UCR = "CLM17", CompanyId = 104, ClaimDate = DateTime.Now.AddDays(-30), LossDate = DateTime.Now.AddDays(60), AssuredName = "", IncurredLoss = 100, Closed = false });

            claims.Add(new Claim { UCR = "CLM18", CompanyId = 102, ClaimDate = DateTime.Now.AddDays(-30), LossDate = DateTime.Now.AddDays(60), AssuredName = "", IncurredLoss = 100, Closed = false });

            claims.Add(new Claim { UCR = "CLM19", CompanyId = 101, ClaimDate = DateTime.Now.AddDays(-30), LossDate = DateTime.Now.AddDays(60), AssuredName = "", IncurredLoss = 100, Closed = false });

            claims.Add(new Claim { UCR = "CLM20", CompanyId = 103, ClaimDate = DateTime.Now.AddDays(-30), LossDate = DateTime.Now.AddDays(60), AssuredName = "", IncurredLoss = 100, Closed = false });

            claims.Add(new Claim { UCR = "CLM21", CompanyId = 106, ClaimDate = DateTime.Now.AddDays(-30), LossDate = DateTime.Now.AddDays(60), AssuredName = "", IncurredLoss = 100, Closed = false });

            claims.Add(new Claim { UCR = "CLM22", CompanyId = 107, ClaimDate = DateTime.Now.AddDays(-30), LossDate = DateTime.Now.AddDays(60), AssuredName = "", IncurredLoss = 100, Closed = false });

            return claims;
        }
    }
}
