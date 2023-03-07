using AutoMapper;
using Strore_APP_ASP_API_MySQL.DTO;
using Strore_APP_ASP_API_MySQL.Models;

namespace Strore_APP_ASP_API_MySQL.Mapper
{
  public class AutoMapperProfile : Profile
  {
    public AutoMapperProfile()
    {
      CreateMap<AuthDTO, MAuth>();
      CreateMap<MClientDTO, MClient>();
      CreateMap<MProductDTO, MProduct>();
      CreateMap<CompanyDTO, MCompany>();
      CreateMap<CartDTO, MCart>();
      CreateMap<DetailsCartDTO, MDetailsCart>();
      CreateMap<ReportsDTO, MReport>();
    }
  }
}


