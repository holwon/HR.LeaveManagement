using HR.LeaveManagement.Application.Dtos.Common;
using MediatR;

namespace HR.LeaveManagement.Application.Dtos.LeaveRequest;

public record CreateLeaveRequestDto : BaseDto
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int LeaveId { get; set; }
    public string? RequestComments { get; set; }
}
