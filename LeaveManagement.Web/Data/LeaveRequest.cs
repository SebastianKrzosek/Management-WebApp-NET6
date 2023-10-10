using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagement.Web.Data
{
    public class LeaveRequest : BaseEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime LeaveRequested { get; set; }
        public string RequsetComment { get; set; }
        public bool? Approved { get; set; }
        public bool Canceled { get; set; }
        public string RequstingEmployeeId { get; set; }

    }
}
