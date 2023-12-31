using HR.LeaveManagement.Application.Dtos.Common;

namespace HR.LeaveManagement.Application.Dtos.LeaveRequest;

public record UpdateLeaveRequestDto : BaseDto
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int LeaveTypeId { get; set; }
    public required string RequestComments { get; set; }
    public bool Cancelled { get; set; }
}
