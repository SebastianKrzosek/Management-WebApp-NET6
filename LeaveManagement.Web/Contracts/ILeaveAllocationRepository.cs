﻿using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;

namespace LeaveManagement.Web.Contracts
{
    public interface ILeaveAllocationRepository: IGenericRepository<LeaveAllocation>
    {
        Task LeaveAllocation(int LeaveTypeId);
        Task<bool> AllocationExists(string employeeId, int leaveTypeId, int peroid);
        Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId);
        Task<LeaveAllocationEditVM> GetEmployeeAllocation(int Id);
        Task<bool> UpdateEmployeeAllocation(LeaveAllocationEditVM model);
    }
}
