using AutoMapper;
using HR.LeaveManagement.Application.Dtos.LeaveType;
using HR.LeaveManagement.Application.Features.LeaveTypes.Request.Queries;
using HR.LeaveManagement.Application.Persistence.Contracts;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveTypes.Handlers.Queries;

public class GetLeaveTypeListRequestHandler(
    ILeaveRequestRepository _leaveRequestRepository,
    IMapper _mapper
) : IRequestHandler<GetLeaveTypeListRequest, List<LeaveTypeDto>>
{
    public async Task<List<LeaveTypeDto>> Handle(
        GetLeaveTypeListRequest request,
        CancellationToken cancellationToken
    )
    {
        var leaveTypes = await _leaveRequestRepository.GetAllAsync();
        return _mapper.Map<List<LeaveTypeDto>>(leaveTypes);
    }
}
