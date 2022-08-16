using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Company
    {
        [Required]
        public int Id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        //Una compania puede tener varios proyectos
        public ICollection<Project> Fk_Projects { get; set; }
    }
}
