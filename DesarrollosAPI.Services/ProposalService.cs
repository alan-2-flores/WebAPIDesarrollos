using AutoMapper;
using DesarrollosAPI.Contracts;
using DesarrollosAPI.DTOS;
using DesarrollosAPI.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesarrollosAPI.Services
{
    public class ProposalService : IProposalService
    {
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;
        public ProposalService(IRepositoryWrapper repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task Create(ProposalRequest responseRequest)
        {
            Proposal project = _mapper.Map<Proposal>(responseRequest);
            _repository.Proposal.Create(project);
            await _repository.Save();
        }
        public async Task<ProposalResponse> GetById(int id)
        {
            var obtainedProject = await _repository.Proposal.GetById(project => project.Id == id);
            ProposalResponse projectResponse = _mapper.Map<ProposalResponse>(obtainedProject);
            return projectResponse;
        }
        public async Task<List<ProposalResponse>> GetAll()
        {
            List<ProposalResponse> projectsResponses = new();
            var obtainedProjects = await _repository.Proposal.GetAll();
            foreach (var project in obtainedProjects)
            {
                projectsResponses.Add(_mapper.Map<ProposalResponse>(project));
            }
            return projectsResponses;
        }

        public async Task Update(ProposalRequestWithId projectRequest)
        {
            Proposal project = _mapper.Map<Proposal>(projectRequest);
            _repository.Proposal.Update(project);
            await _repository.Save();
        }

        public async Task Delete(int id)
        {
            var projectCompany = await _repository.Proposal.GetById(project => project.Id == id);
            _repository.Proposal.Delete(projectCompany);
            await _repository.Save();
        }
    }
}
