using System;
using AutoMapper;
using Class = SchoolPlan.Web.Models.Class;

namespace SchoolPlan.Web.Mapping
{
    public class ServiceProfile : Profile
    {
        [Obsolete("Create a constructor and configure inside of your profile\'s constructor instead. Will be removed in 6.0")]
        protected override void Configure()
        {
            CreateMap<Services.Interface.Models.Class, Class>().ReverseMap();
        }
    }
}