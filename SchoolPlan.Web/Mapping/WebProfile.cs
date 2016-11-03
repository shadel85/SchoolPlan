using System;
using AutoMapper;
using SchoolPlan.DataAccess.Interface.Models;

namespace SchoolPlan.Web.Mapping
{
    public class WebProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<Class, Services.Interface.Models.Class>()
                .ForMember(dest => dest.StudentClasses, opt => opt.Ignore())
                .ForMember(dest => dest.Teacher, opt => opt.Ignore())
                .ForMember(dest => dest.Location, opt => opt.Ignore())
                .ForMember(dest => dest.ClassId, opt=>opt.MapFrom(src=>src.Id))
                .ForMember(dest => dest.ClassId, opt => opt.MapFrom(src => src.Id))
                .ReverseMap()
                 .ForMember(dest => dest.StudentClasses, opt => opt.Ignore())
                .ForMember(dest => dest.Teacher, opt => opt.Ignore())
                .ForMember(dest => dest.Location, opt => opt.Ignore())
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ClassId));
           // CreateMap<Teacher, Services.Interface.Models.Teacher>().ReverseMap();
            //CreateMap<Location, Services.Interface.Models.Location>().ReverseMap();
        }
    }
}