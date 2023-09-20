using AutoMapper;
using LeaveManagement.Web.Data;

namespace LeaveManagement.Web.Models.Configuration
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }
    }
}
