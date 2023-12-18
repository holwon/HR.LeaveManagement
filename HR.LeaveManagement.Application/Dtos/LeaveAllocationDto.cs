using HR.LeaveManagement.Application.Dtos.Common;

namespace HR.LeaveManagement.Application.Dtos;

public record LeaveAllocationDto : BaseDto
{
    public int NumberOfDays { get; set; }

    public LeaveTypeDto? LeaveType { get; set; }
    public int LeaveTypeId { get; set; }
    public int Period { get; set; }
    public required string EmployeeId { get; set; }
}
