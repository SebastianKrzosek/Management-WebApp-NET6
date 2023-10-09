namespace LeaveManagement.Web.Models
{
    public class LeaveAllocationVM
    {
        public int Id {  get; set; }    
        public int NumbersOfDays { get; set; }
        public int Peroid { get; set; }
        public LeaveTypeVM LeaveType { get; set; }  

    }
}