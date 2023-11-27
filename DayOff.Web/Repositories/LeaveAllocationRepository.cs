using AutoMapper;
using DayOff.Web.Constants;
using DayOff.Web.Contracts;
using DayOff.Web.Data;
using DayOff.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;

namespace DayOff.Web.Repositories
{
    public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<Employee> userManager;
        private readonly ILeaveTypeRepository leaveTypeRepository;
        private readonly IMapper mapper;
        private readonly IEmailSender emailSender;

        // inject user manager to retrieve all employees and ILeaveTypeRepository to retrieve leavetype properties
        public LeaveAllocationRepository(ApplicationDbContext context,
            UserManager<Employee> userManager, ILeaveTypeRepository leaveTypeRepository, 
            IMapper mapper, IEmailSender emailSender) : base(context)
        {
            this.context = context;
            this.userManager = userManager;
            this.leaveTypeRepository = leaveTypeRepository;
            this.mapper = mapper;
            this.emailSender = emailSender;
        }

        public async Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period)
        {
            return await context.LeaveAllocations.AnyAsync
                (q => q.EmployeeId == employeeId && q.LeaveTypeId == leaveTypeId && q.Period == period);
        }

        // to display employee leave allocations using the employee allocation view model
        public async Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId)
        {
            // get all allocations and leave type for target employee from the database
            var allocations  = await context.LeaveAllocations
                .Include(q => q.LeaveType)
                .Where(q => q.EmployeeId == employeeId).ToListAsync();

            // get target employee details
            var employee = await userManager.FindByIdAsync(employeeId);

            // map the employee details and leave allocations to the employee allocation view model
            var employeeAllocationModel = mapper.Map<EmployeeAllocationVM>(employee);
            employeeAllocationModel.LeaveAllocations = mapper.Map<List<LeaveAllocationVM>>(allocations);

            return employeeAllocationModel;
        }

        public async Task<LeaveAllocationEditVM> GetEmployeeAllocation(int id)
        {
            // get allocation and leave type for target employee from the database
            var allocation = await context.LeaveAllocations
                .Include(q => q.LeaveType)
                .FirstOrDefaultAsync(q => q.Id == id);

            if (allocation == null)
            {
                return null;
            }

            // get target employee details
            var employee = await userManager.FindByIdAsync(allocation.EmployeeId);

            // Convert database result to view model
            var model = mapper.Map<LeaveAllocationEditVM>(allocation);
            model.Employee = mapper.Map<EmployeeListVM>(employee);

            return model;
        }

        public async Task LeaveAllocation(int leaveTypeId)
        {
            var employees = await userManager.GetUsersInRoleAsync(Roles.User); // get all normal user employees
            var period = DateTime.Now.Year; // year of allocation
            var leaveType = await leaveTypeRepository.GetAsync(leaveTypeId); // get leaveType being allocated with leaveTypeId
            var allocations = new List<LeaveAllocation>(); // create list of all allocations
            var employeesWithNewAllocations = new List<Employee>();

            foreach (var employee in employees)
            {
                // check if allocation already exists for target employee
                if (await AllocationExists(employee.Id, leaveTypeId, period))
                    continue;

                allocations.Add(new LeaveAllocation
                {
                    EmployeeId = employee.Id,
                    LeaveTypeId = leaveTypeId,
                    Period = period,
                    NumberOfDays = leaveType.DefaultDays
                });
                employeesWithNewAllocations.Add(employee);
            }
            await AddRangeAsync(allocations);

            foreach (var employee in employeesWithNewAllocations)
            {
                await emailSender.SendEmailAsync(employee.Email, $"Leave Allocation for {period}", $"Your {leaveType.Name} leave allocation " +
                    $"for {period} has been posted. You have been allocated {leaveType.DefaultDays} days.");
            }
        }

        public async Task<bool> UpdateEmployeeAllocation(LeaveAllocationEditVM model)
        {
            var leaveAllocation = await GetAsync(model.Id);
            if (leaveAllocation == null)
            {
                return false;
            }
            leaveAllocation.Period = model.Period;
            leaveAllocation.NumberOfDays = model.NumberOfDays;
            await UpdateAsync(leaveAllocation);

            var user = await userManager.FindByIdAsync(leaveAllocation.EmployeeId);

            await emailSender.SendEmailAsync(user.Email, $"Leave Allocation Updated",
                $"Your {leaveAllocation.LeaveType} leave allocation for {leaveAllocation.Period} has been updated. Please review your allocations.");

            return true;
        }

        public async Task<LeaveAllocation?> FindEmployeeAllocation(string employeeId, int leaveTypeId)
        {
            return await context.LeaveAllocations.FirstOrDefaultAsync(q => q.EmployeeId == employeeId && q.LeaveTypeId == leaveTypeId);
        }
    }
}
