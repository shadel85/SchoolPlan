﻿using System;
using AutoMapper;
using SchoolPlan.DataAccess.Interface.Models;

namespace SchoolPlan.DataAccess.Mapping
{
    public class DataAccessProfile : Profile
    {
        public DataAccessProfile()
        {
            CreateMap<Data.Entities.Class, Class>().ReverseMap();
        }
    }
}
