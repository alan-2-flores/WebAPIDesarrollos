namespace DesarrollosAPI.DTOS
{
    public class AssignmentResponse
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }
        public int ProjectId { get; set; }
        public CompanyResponse Company { get; set; }
        public ProjectResponse Project { get; set; }
        public AssignmentResponse()
        {

        }
    }
}

