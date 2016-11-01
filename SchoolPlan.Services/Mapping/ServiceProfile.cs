using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SchoolPlan.Services.Interface.Models;

namespace SchoolPlan.Services.Mapping
{
    public class ServiceProfile:Profile
    {
        [Obsolete(
            "Create a constructor and configure inside of your profile\'s constructor instead. Will be removed in 6.0")]
        protected override void Configure()
        {
            CreateMap<DataAccess.Interface.Models.Class, Class>().ReverseMap();
        }
    }
}