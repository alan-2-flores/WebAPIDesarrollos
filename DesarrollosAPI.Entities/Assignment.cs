using System.ComponentModel.DataAnnotations.Schema;

namespace DesarrollosAPI.Entities
{
    public class Assignment
    {
        public int Id { get; set; }

        [ForeignKey("Company")]
        public int CompanyId { get; set; }

        [ForeignKey("Project")]
        public int ProjectId { get; set; }
        public Company Company { get; set; }
        public Project Project { get; set; }
    }
}
