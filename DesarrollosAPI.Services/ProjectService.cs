using AutoMapper;
using DesarrollosAPI.Contracts;
using DesarrollosAPI.DTOS;
using DesarrollosAPI.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesarrollosAPI.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;
        public ProjectService(IRepositoryWrapper repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task Create(ProjectRequest responseRequest)
        {
            Project project = _mapper.Map<Project>(responseRequest);
            _repository.Project.Create(project);
            await _repository.Save();
        }
        public async Task<ProjectResponse> GetById(int id)
        {
            var obtainedProject = await _repository.Project.GetById(project => project.Id == id);
            ProjectResponse projectResponse = _mapper.Map<ProjectResponse>(obtainedProject);
            return projectResponse;
        }
        public async Task<List<ProjectResponse>> GetAll()
        {
            List<ProjectResponse> projectsResponses = new();
            var obtainedProjects = await _repository.Project.GetAll();
            foreach (var project in obtainedProjects)
            {
                projectsResponses.Add(_mapper.Map<ProjectResponse>(project));
            }
            return projectsResponses;
        }

        public async Task Update(ProjectRequestWithId projectRequest)
        {
            Project project = _mapper.Map<Project>(projectRequest);
            _repository.Project.Update(project);
            await _repository.Save();
        }

        public async Task Delete(int id)
        {
            var projectCompany = await _repository.Project.GetById(project => project.Id == id);
            _repository.Project.Delete(projectCompany);
            await _repository.Save();
        }
    }
}
