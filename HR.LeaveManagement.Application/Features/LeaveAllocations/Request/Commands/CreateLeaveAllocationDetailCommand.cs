using HR.LeaveManagement.Application.Dtos.LeaveAllocation;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveAllocations.Request.Commands;

public class CreateLeaveAllocationDetailCommand : IRequest<int>
{
    public required LeaveAllocationDto LeaveAllocationDto { get; set; }
}
