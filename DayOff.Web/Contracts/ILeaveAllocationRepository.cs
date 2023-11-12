using DayOff.Web.Data;
using DayOff.Web.Models;

namespace DayOff.Web.Contracts
{
    // connecting to the IGenericRepository interface
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        Task LeaveAllocation(int leaveTypeId);
        Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period);
        Task<EmployeeAllocationVM> GetEmployeeAllocations (string employeeId);
        Task<LeaveAllocationEditVM> GetEmployeeAllocation (int id);
        Task<LeaveAllocation?> FindEmployeeAllocation (string employeeId, int leaveTypeId);
        Task<bool> UpdateEmployeeAllocation (LeaveAllocationEditVM model);
    }
}
