using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SchoolPlan.DataAccess.Interface.Models;

namespace SchoolPlan.DataAccess.Mapping
{
    public class DataAccessProfile : Profile
    {
        protected void Configure()
        {
            //Mapper.Initialize(cfg =>
            //{
            //    CreateMap<Data.Entities.Class, Class>()
            //        .ForMember(dest => dest.ClassId, opt => opt.MapFrom(src => src.ClassID))
            //        .ForMember(dest => dest.Location,
            //            opt => opt.MapFrom(src => new Location { LocationId = src.LocationID }))
            //        .ForMember(dest => dest.TeacherId,
            //            opt => opt.MapFrom(src => new Teacher() { TeacherId = src.TeacherID }));
            //});

            //Mapper.Initialize(cfg =>
            //{
            //    CreateMap<Class, Data.Entities.Class>()
            //        .ForMember(dest => dest.ClassID, opt => opt.MapFrom(src => src.ClassId))
            //        .ForMember(dest => dest.LocationID, opt => opt.MapFrom(src => src.LocationId))
            //        .ForMember(dest => dest.TeacherID, opt => opt.MapFrom(src => src.TeacherId));
            //});
        }
    }
}
