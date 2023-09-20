using LeaveManagement.Web.Data;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }
        [Display(Name = "Leave Type Name")]
        public string Name { get; set; }
        [Display(Name = "Default numbers of days")]
        public int DefaultDays { get; set; }
    }
}
