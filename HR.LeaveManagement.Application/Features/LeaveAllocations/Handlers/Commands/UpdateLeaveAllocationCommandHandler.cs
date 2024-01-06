using AutoMapper;
using HR.LeaveManagement.Application.Features.LeaveAllocations.Request.Commands;
using HR.LeaveManagement.Application.Persistence.Contracts;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveAllocations.Handlers.Commands;

public class UpdateLeaveAllocationCommandHandler(
    ILeaveAllocationRepository _leaveAllocationRepository,
    IMapper _mapper
) : IRequestHandler<UpdateLeaveAllocationCommand, Unit>
{
    public async Task<Unit> Handle(
        UpdateLeaveAllocationCommand request,
        CancellationToken cancellationToken
    )
    {
        var leaveAllocation = await _leaveAllocationRepository.GetAsync(
            request.LeaveAllocationDto.Id
        );
        _mapper.Map(request.LeaveAllocationDto, leaveAllocation);
        await _leaveAllocationRepository.UpdateAsync(leaveAllocation);
        return Unit.Value;
    }
}
