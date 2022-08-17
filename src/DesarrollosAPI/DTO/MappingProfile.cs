﻿using AutoMapper;
using DesarrollosAPI.Models;

namespace DesarrollosAPI.DTO
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CompanyRequest, Company>();
            CreateMap<Company, CompanyResponse>();
            CreateMap<CompanyRequestWithId, Company>();
        }
    }
}
