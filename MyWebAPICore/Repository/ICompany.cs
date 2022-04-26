using System;
using System.Collections.Generic;
using dev42.Keval.Dotnet_API.Models;

namespace MyWebAPICore.Repository
{
    public interface ICompany
    {
        
        public Company AddCompanyRepo(Company company);
        public void DeleteCompanyRepo(Guid id);
        // public Company EditCompany(Guid id);
        public Company EditCompanyRepo(Company company);
        public List<Company> CompanyListRepo();
        public Company GetCompanyRepo(Guid id);

        

        
    }
}