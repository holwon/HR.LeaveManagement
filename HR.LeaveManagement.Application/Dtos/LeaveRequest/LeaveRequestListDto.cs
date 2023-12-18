using HR.LeaveManagement.Application.Dtos.Common;

namespace HR.LeaveManagement.Application.Dtos.LeaveRequest;

public record LeaveRequestListDto : BaseDto
{
    public required LeaveTypeDto LeaveType { get; set; }
    public DateTime DateRequested { get; set; }

    public bool Approved { get; set; }
}
