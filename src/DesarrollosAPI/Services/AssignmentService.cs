using AutoMapper;
using DesarrollosAPI.Contracts;
using DesarrollosAPI.DTO;
using DesarrollosAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesarrollosAPI.Services
{
    public class AssignmentService : IAssignmentService
    {
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;
        public AssignmentService(IRepositoryWrapper repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Create(AssignmentRequest assignmentRequest)
        {
            Assignment assignment = _mapper.Map<Assignment>(assignmentRequest);
            _repository.Assignment.Create(assignment);
            await _repository.Save();
        }
        public async Task<AssignmentResponse> GetById(int id)
        {
            var obtainedAssignment = await _repository.Assignment.GetById(assignment => assignment.Id == id);
            AssignmentResponse assignmentResponse = _mapper.Map<AssignmentResponse>(obtainedAssignment);
            return assignmentResponse;
        }
        public async Task<List<AssignmentResponse>> GetAll()
        {
            List<AssignmentResponse> companiesResponses = new();
            var obtainedCompanies = await _repository.Assignment.GetAll();
            foreach (var assignment in obtainedCompanies)
            {
                companiesResponses.Add(_mapper.Map<AssignmentResponse>(assignment));
            }
            return companiesResponses;
        }

        public async Task Update(AssignmentRequestWithId assignmentRequest)
        {
            Assignment assignment = _mapper.Map<Assignment>(assignmentRequest);
            _repository.Assignment.Update(assignment);
            await _repository.Save();
        }

        public async Task Delete(int id)
        {
            var obtainedAssignment = await _repository.Assignment.GetById(assignment => assignment.Id == id);
            _repository.Assignment.Delete(obtainedAssignment);
            await _repository.Save();
        }
    }
}
