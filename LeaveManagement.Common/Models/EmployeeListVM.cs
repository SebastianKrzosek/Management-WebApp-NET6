using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace LeaveManagement.Common.Models
{
    public class EmployeeListVM
    {
        public string Id { get; set; }
        [Display(Name = "Name")]
        public string FirstName { get; set; }
        [Display(Name = "Surname")]
        public string LastName { get; set; }
        [Display(Name = "E-mail")]
        public string Email { get; set; }
        [Display(Name = "Date Joined")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        public DateTime DateJoined { get; set; }   
    }
}
