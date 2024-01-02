using HR.LeaveManagement.Application.Dtos.LeaveType;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveTypes.Request.Commands;

public class CreateLeaveTypeCommand : IRequest<int>
{
    public required LeaveTypeDto LeaveTypeDto { get; set; }
}
