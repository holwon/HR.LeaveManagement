using HR.LeaveManagement.Application.Dtos.Common;

namespace HR.LeaveManagement.Application.Dtos.LeaveAllocation;

public record CreateLeaveAllocationDto
{
    public int NumberOfDays { get; set; }
    public int LeaveTypeId { get; set; }
    public int Period { get; set; }
}
