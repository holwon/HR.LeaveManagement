using AutoMapper;
using HR.LeaveManagement.Application.Dtos;
using HR.LeaveManagement.Application.Features.LeaveAllocations.Request.Queries;
using HR.LeaveManagement.Application.Persistence.Contracts;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveAllocations.Handlers.Queries;

public class GetLeaveAllocationListRequestHandler(
    ILeaveAllocationRepository _leaveAllocationRepository,
    IMapper _mapper
) : IRequestHandler<GetLeaveAllocationListRequest, List<LeaveAllocationDto>>
{
    public async Task<List<LeaveAllocationDto>> Handle(
        GetLeaveAllocationListRequest request,
        CancellationToken cancellationToken
    )
    {
        var leaveAllocations =
            await _leaveAllocationRepository.GetLeaveAllocationsWithDetailsAsync();
        var response = _mapper.Map<List<LeaveAllocationDto>>(leaveAllocations);
        return response;
    }
}
