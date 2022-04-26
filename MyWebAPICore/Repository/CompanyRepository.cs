using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using dev42.Keval.Dotnet_API.Models;
using Microsoft.EntityFrameworkCore;

namespace MyWebAPICore.Repository
{
    public class CompanyRepository : ICompany
    {
        private readonly ApplicationDbContext _AppDbContext;
        private readonly IMapper _mapper;
        public CompanyRepository(ApplicationDbContext AppDbContext, IMapper mapper)
        {
            _AppDbContext = AppDbContext;
            _mapper = mapper;
        }

        // This method is used for Inserting the data.
        public Company AddCompanyRepo(Company company)
        {
            var addcomp = _AppDbContext.Companies.Add(company);
            _AppDbContext.SaveChanges();
            return company;
        }
        // This method is used for Deleting the data. 
        public void DeleteCompanyRepo(Guid id)
        {
            var delcompany = _AppDbContext.Companies.Find(id);
            if (delcompany != null)
                _AppDbContext.Companies.Remove(delcompany);
            _AppDbContext.SaveChanges();
          
        }


        // This mehtod is used for Getting the data.
        // public Company EditCompany(Guid id)
        // {
        //     var editcompany = _AppDbContext.Companies.FirstOrDefault(x => x.Id == id);
        //     return editcompany;

        // var findId = _AppDbContext.Companies.FirstOrDefault(x => x.Id == id);
        // return _mapper.Map<Company>(findId);
        // }


        //This method is used for Updating the data.
        public Company EditCompanyRepo(Company company)
        {
            var editcompany = _AppDbContext.Update(company);
            _AppDbContext.SaveChanges();
            return company;
        }

        //This Mehtod is used for List the data.
        public List<Company> CompanyListRepo()
        {
            var companylist = _AppDbContext.Companies.ToList();
            return companylist;
        }


        //This method is used for getting the data by ID.
        // public Company GetCompany(Guid id)
        // {
        //     var company = _AppDbContext.Companies.Find(id);
        //     return company;
            // var company = _AppDbContext.Companies.Find(id);
            // return _mapper.Map<Company>(company);
        // }

        //To include data in 
        public Company GetCompanyRepo(Guid id)
        {
            var company = _AppDbContext.Companies.Include(x => x.Locations).FirstOrDefault(x => x.Id == id);
            return company;
        }
    }
}