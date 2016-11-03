using AutoMapper;
using SchoolPlan.DataAccess.Interface.Models;

namespace SchoolPlan.DataAccess.Interface.Mapping
{
    public class DataAccessProfile : Profile
    {
        public DataAccessProfile()
        {
            CreateMap<Data.Entities.Class, Class>().ReverseMap();
        }
    }
}
