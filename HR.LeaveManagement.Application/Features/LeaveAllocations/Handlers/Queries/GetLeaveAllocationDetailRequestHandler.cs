using AutoMapper;
using HR.LeaveManagement.Application.Dtos.LeaveAllocation;
using HR.LeaveManagement.Application.Features.LeaveAllocations.Request.Queries;
using HR.LeaveManagement.Application.Persistence.Contracts;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveAllocations.Handlers.Queries;

public class GetLeaveAllocationDetailRequestHandler(
    ILeaveAllocationRepository _leaveAllocationRepository,
    IMapper _mapper
) : IRequestHandler<GetLeaveAllocationDetailRequest, LeaveAllocationDto>
{
    public async Task<LeaveAllocationDto> Handle(
        GetLeaveAllocationDetailRequest request,
        CancellationToken cancellationToken
    )
    {
        var leaveAllocation = await _leaveAllocationRepository.GetLeaveAllocationWithDetailsAsync(
            request.Id
        );

        var response = _mapper.Map<LeaveAllocationDto>(leaveAllocation);
        return response;
    }
}
