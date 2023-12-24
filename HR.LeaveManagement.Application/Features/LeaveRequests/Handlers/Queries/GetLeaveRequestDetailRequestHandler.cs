using AutoMapper;
using HR.LeaveManagement.Application.Dtos.LeaveRequest;
using HR.LeaveManagement.Application.Features.LeaveRequests.Request.Queries;
using HR.LeaveManagement.Application.Persistence.Contracts;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveRequests.Handlers.Queries;

public class GetLeaveRequestDetailRequestHandler(
    ILeaveRequestRepository _leaveRequestRepository,
    IMapper _mapper
) : IRequestHandler<GetLeaveRequestDetailRequest, LeaveRequestDto>
{
    public async Task<LeaveRequestDto> Handle(
        GetLeaveRequestDetailRequest request,
        CancellationToken cancellationToken
    )
    {
        var leaveRequest = await _leaveRequestRepository.GetLeaveRequestWithDetailAsync(request.Id);

        var response = _mapper.Map<LeaveRequestDto>(leaveRequest);
        return response;
    }
}
