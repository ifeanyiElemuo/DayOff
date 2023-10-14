using AutoMapper;
using DayOff.Web.Data;
using DayOff.Web.Models;

namespace DayOff.Web.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }
    }
}
