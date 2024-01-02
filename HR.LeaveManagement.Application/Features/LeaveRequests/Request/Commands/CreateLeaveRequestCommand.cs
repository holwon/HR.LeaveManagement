using HR.LeaveManagement.Application.Dtos.LeaveRequest;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveRequests.Request.Commands;

public class CreateLeaveRequestCommand : IRequest<int>
{
    public required LeaveRequestDto LeaveRequestDto { get; set; }
}
