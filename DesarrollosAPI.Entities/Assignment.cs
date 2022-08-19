using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesarrollosAPI.Entities
{
    public class Assignment
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime DeadLineDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }


        [ForeignKey("Company")]
        public int CompanyId { get; set; }

        [ForeignKey("Proposal")]
        public int ProposalId { get; set; }
        public Company Company { get; set; }
        public Proposal Proposal { get; set; }
    }
}
