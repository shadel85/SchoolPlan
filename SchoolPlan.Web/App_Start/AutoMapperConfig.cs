using AutoMapper;
using SchoolPlan.Web.Models;

namespace SchoolPlan.Web
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration Configure()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Class, Services.Interface.Models.Class>()
                .ForMember(dest => dest.StudentClasses, opt => opt.Ignore())
                .ForMember(dest => dest.Teacher, opt => opt.Ignore())
                .ForMember(dest => dest.Location, opt => opt.Ignore())
                .ForMember(dest => dest.ClassId, opt => opt.MapFrom(src => src.ClassId))
                .ForMember(dest => dest.ClassId, opt => opt.MapFrom(src => src.ClassId))
                .ReverseMap()
                .ForMember(dest => dest.StudentClasses, opt => opt.Ignore())
                .ForMember(dest => dest.Teacher, opt => opt.Ignore())
                .ForMember(dest => dest.Location, opt => opt.Ignore())
                .ForMember(dest => dest.ClassId, opt => opt.MapFrom(src => src.ClassId));


            });
            return config;
        }
    }
}