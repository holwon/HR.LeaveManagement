using AutoMapper;
using HR.LeaveManagement.Application.Features.LeaveAllocations.Request.Commands;
using HR.LeaveManagement.Application.Persistence.Contracts;
using HR.LeaveManagement.Domain;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveAllocations.Handlers.Commands;

public class CreateLeaveAllocationDetailCommandHandler(
    ILeaveAllocationRepository _leaveAllocationRepository,
    IMapper _mapper
) : IRequestHandler<CreateLeaveAllocationDetailCommand, int>
{
    public async Task<int> Handle(
        CreateLeaveAllocationDetailCommand request,
        CancellationToken cancellationToken
    )
    {
        var leaveAllocation = _mapper.Map<LeaveAllocation>(request.LeaveAllocationDto);
        leaveAllocation = await _leaveAllocationRepository.AddAsync(leaveAllocation);
        return leaveAllocation.Id;
    }
}
