using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management.Models
{
    public class LeaveAllocation
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int NumberOfDays { get; set; }

        public DateTime DateCreated { get; set; }

        //referencxe to the employee
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
        public string EmployeeId { get; set; }
        [ForeignKey("LeaveTypeId")]
        public LeaveType leaveType { get; set; }

        public int LeaveTypeId { get; set; }
    }
}
