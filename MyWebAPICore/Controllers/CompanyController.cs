using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using dev42.Keval.Dotnet_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyWebAPICore.DTO;
using MyWebAPICore.Repository;

namespace MyWebAPICore.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class CompanyController : ControllerBase
    {
        private readonly ILogger<CompanyController> _logger;
        public readonly ICompany _company;
        private readonly IMapper _mapper;

        public CompanyController(ILogger<CompanyController> logger, ICompany company, IMapper mapper)
        {
            _logger = logger;

            _company = company;

            _mapper = mapper;
        }


        [HttpPost("Add")]
        public bool AddCompany(CompanyDTO input)
        {
            //Simple Method..

            // var company = new Company();
            // company.Name = input.Name;
            // company.Email = input.Email;
            // company.Phone = input.Phone;
            // company.Website = input.Website;

            //Mapping Method..
            var company = _mapper.Map<Company>(input);


            // Foreach to Add data in Location Table
            foreach (var locate in input.Locations)
            {
                var locationdata = _mapper.Map<Location>(locate);

                company.Locations.Add(locationdata);

            }

            // company.Locations = locations;

            _company.AddCompanyRepo(company);

            return true;

        }

        [HttpDelete]
        public void DeleteCompany(Guid id)
        {
            _company.DeleteCompanyRepo(id);
        }

        // [HttpGet]
        // public Company EditCompany(Guid id)
        // {
        //     var editcompany = _company.EditCompany(id);
        //     return editcompany;
        // }

        //This method is for updating Company data only..
        // [HttpPost("Update")]
        // public Company EditCompany(CompanyDTO input, Guid Id)
        // {
           
            // Simple Method..

            // var editcompany = _company.EditCompany(Id);
            // editcompany.Name = input.Name;
            // editcompany.Email = input.Email;
            // editcompany.Phone = input.Phone;
            // editcompany.Website = input.Website;

            // Auto-Mapping method..
        //     var editcompany = _mapper.Map<Company>(input);
        //     _company.EditCompany(editcompany);
        //     return editcompany;
        // }
        [HttpPost("Update")]
        public IActionResult GetCompany(CompanyDTO input, Guid Id)
        {
            var company = _company.GetCompanyRepo(Id);

            _mapper.Map(input, company);

            var locations = new List<Location>();

            foreach (var location in input.Locations)
            {
                var locate = _mapper.Map<Location>(location);

                locations.Add(locate);
            }
            company.Locations = locations;
            _company.EditCompanyRepo(company);  //****get Id****//

            return Ok();

        }

        [HttpGet("GetId")]
        public Company GetCompany(Guid Id)
        {
            var Get = _company.GetCompanyRepo(Id);
            return Get;
        }
        [HttpPost("Paging")]
        public List<Company> CompanyList(PagingDTO input)
        {

            var companylist = _company.CompanyListRepo();

            var count = companylist.Count();
            var items = companylist.Skip((input.pageNumber - 1) * input.pageSize).Take(input.pageSize).ToList()
            .Skip((input.pageNumber - 1) * input.pageSize)

             .Take(input.pageSize)

             .ToList(); ;

            return items;
            //return companylist;
        }



    }
}