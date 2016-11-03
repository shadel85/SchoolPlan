using AutoMapper;
using SchoolPlan.Services.Interface.Models;

namespace SchoolPlan.Services.Interface.Mapping
{
    public class ServiceProfile : Profile
    {
        public ServiceProfile()
        {
            CreateMap<DataAccess.Interface.Models.Class, Class>().ReverseMap();
        }
    }
}