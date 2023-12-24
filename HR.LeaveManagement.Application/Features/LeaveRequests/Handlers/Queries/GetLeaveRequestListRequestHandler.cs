using AutoMapper;
using HR.LeaveManagement.Application.Dtos.LeaveRequest;
using HR.LeaveManagement.Application.Features.LeaveRequests.Request.Queries;
using HR.LeaveManagement.Application.Persistence.Contracts;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveRequests.Handlers.Queries;

public class GetLeaveRequestListRequestHandler(
    ILeaveRequestRepository _leaveRequestRepository,
    IMapper _mapper
) : IRequestHandler<GetLeaveRequestListRequest, List<LeaveRequestDto>>
{
    public async Task<List<LeaveRequestDto>> Handle(
        GetLeaveRequestListRequest request,
        CancellationToken cancellationToken
    )
    {
        var leaveRequests = await _leaveRequestRepository.GetLeaveRequestsWithDetailAsync();
        var response = _mapper.Map<List<LeaveRequestDto>>(leaveRequests);
        return response;
    }
}
