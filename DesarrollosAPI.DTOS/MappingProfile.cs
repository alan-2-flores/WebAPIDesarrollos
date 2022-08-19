using AutoMapper;
using DesarrollosAPI.Entities;

namespace DesarrollosAPI.DTOS
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CompanyRequest, Company>();
            CreateMap<Company, CompanyResponse>();
            CreateMap<CompanyRequestWithId, Company>();
            //CreateMap<CompanyRequestWithId, Company>().ForMember(dto => dto.Name, cfg => cfg.MapFrom(entity => entity.Name));

            CreateMap<ProjectRequest, Project>();
            CreateMap<Project, ProjectResponse>();
            CreateMap<ProjectRequestWithId, Project>();

            CreateMap<AssignmentRequest, Assignment>();
            CreateMap<Assignment, AssignmentResponse>();
            CreateMap<AssignmentRequestWithId, Assignment>();
        }
    }
}
