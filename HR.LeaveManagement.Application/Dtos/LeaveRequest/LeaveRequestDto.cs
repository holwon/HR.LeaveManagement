using HR.LeaveManagement.Application.Dtos.Common;
using HR.LeaveManagement.Application.Dtos.LeaveType;

namespace HR.LeaveManagement.Application.Dtos.LeaveRequest;

public record LeaveRequestDto : BaseDto
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public LeaveTypeDto? LeaveType { get; set; }
    public int LeaveTypeId { get; set; }
    public DateTime DateRequested { get; set; }
    public string? RequestComments { get; set; }

    // 可空, 表示这个 request 什么时候 Approved 或 Cancelled
    public DateTime? DateActioned { get; set; }
    public bool Approved { get; set; }
    public bool Cancelled { get; set; }
}
