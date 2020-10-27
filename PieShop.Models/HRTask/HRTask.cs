using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PieShop.Models.HRTask
{
    public class HRTask
    {
        public int HRTaskId { get; set; }
        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public int AssignedTo { get; set; } // this interget will hold the EmployeeId

        public HRTaskStatus Status { get; set; }
    }
}
