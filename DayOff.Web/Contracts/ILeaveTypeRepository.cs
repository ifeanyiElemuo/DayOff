using DayOff.Web.Data;
using DayOff.Web.Repositories;

namespace DayOff.Web.Contracts
{
    // connecting to the IGenericRepository interface
    public interface ILeaveTypeRepository : IGenericRepository<LeaveType>
    {
    }
}
