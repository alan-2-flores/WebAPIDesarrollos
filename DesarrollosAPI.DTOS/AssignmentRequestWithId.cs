﻿using System;
using System.ComponentModel.DataAnnotations;

namespace DesarrollosAPI.DTOS
{
    public class AssignmentRequestWithId
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime DeadLineDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }

        public int CompanyId { get; set; }
        public int ProposalId { get; set; }


        public AssignmentRequestWithId()
        {

        }
    }
}
