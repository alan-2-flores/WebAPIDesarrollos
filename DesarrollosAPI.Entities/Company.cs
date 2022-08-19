using System.ComponentModel.DataAnnotations;

namespace DesarrollosAPI.Entities
{
    public class Company
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        //Una compania puede tener varios proyectos
        //public ICollection<Project> Fk_Projects { get; set; }
    }
}
