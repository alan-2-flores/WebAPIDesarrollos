namespace DesarrollosAPI.Models
{
    public class Assigment
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int ProjectId { get; set; }
        public Company Company { get; set; }
        public Project Project { get; set; }
    }
}
