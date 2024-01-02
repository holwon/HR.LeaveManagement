using AutoMapper;
using HR.LeaveManagement.Application.Dtos.LeaveType;
using HR.LeaveManagement.Application.Features.LeaveTypes.Request.Queries;
using HR.LeaveManagement.Application.Persistence.Contracts;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveTypes.Handlers.Queries;

public class GetLeaveTypeDetailRequestHandler(
    ILeaveTypeRepository _leaveTypeRepository,
    IMapper _mapper
) : IRequestHandler<GetLeaveTypeDetailRequest, LeaveTypeDto>
{
    public async Task<LeaveTypeDto> Handle(
        GetLeaveTypeDetailRequest request,
        CancellationToken cancellationToken
    )
    {
        var leaveType = await _leaveTypeRepository.GetAsync(request.Id);
        return _mapper.Map<LeaveTypeDto>(leaveType);
    }
}
