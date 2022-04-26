using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using dev42.Keval.Dotnet_API.Models;
using MyWebAPICore.DTO;

namespace Namespace
{
    public class CompanyProfile : Profile
    {
        public CompanyProfile()
        {
            CreateMap<Company, CompanyDTO>().ReverseMap();
            
            CreateMap<Location, LocationDTO>().ReverseMap();

            
            // CreateMap<CompanyDTO, Company>();
        }
    }
}
