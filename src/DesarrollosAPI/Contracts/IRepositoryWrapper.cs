namespace DesarrollosAPI.Contracts
{
    public interface IRepositoryWrapper
    {
        IAssignmentRepository Assignment { get; }
        ICompanyRepository Company { get; }
        IProjectRepository Project { get; }
        void Save();
    }
}
