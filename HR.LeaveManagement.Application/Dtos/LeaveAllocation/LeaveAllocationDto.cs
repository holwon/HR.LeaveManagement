using HR.LeaveManagement.Application.Dtos.Common;

namespace HR.LeaveManagement.Application.Dtos.LeaveAllocation;

public record LeaveAllocationDto : BaseDto
{
    public int NumberOfDays { get; set; }

    public LeaveTypeDto? LeaveType { get; set; }
    public int LeaveTypeId { get; set; }
    public int Period { get; set; }
    public required string EmployeeId { get; set; }
}
