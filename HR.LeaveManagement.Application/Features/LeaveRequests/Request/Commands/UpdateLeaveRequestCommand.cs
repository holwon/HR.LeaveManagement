using HR.LeaveManagement.Application.Dtos.LeaveRequest;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveRequests.Request.Commands;

public class UpdateLeaveRequestCommand : IRequest<Unit>
{
    public int Id { get; set; }
    public LeaveRequestDto? LeaveRequestDto { get; set; }
    public ChangeLeaveRequestApprovalDto? ChangeLeaveRequestApprovalDto { get; set; }
}
