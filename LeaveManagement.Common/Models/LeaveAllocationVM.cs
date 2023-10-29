using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Common.Models
{
    public class LeaveAllocationVM
    {
        [Required]
        public int Id {  get; set; }
        [Display(Name = "Numbers Of Days")]
        [Range(1, 50, ErrorMessage = "Invalid Number Entered")]
        [Required]
        public int NumberOfDays { get; set; }
        [Display(Name = "Allocation Peroid")]
        
        [Required]
        public int Peroid { get; set; }
        public LeaveTypeVM? LeaveType { get; set; }  

    }
}