namespace LeaveManagement.Web.Data
{
    public partial class BaseEntity
    {
        public int Id { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateModified { get; set; }
    }
}
