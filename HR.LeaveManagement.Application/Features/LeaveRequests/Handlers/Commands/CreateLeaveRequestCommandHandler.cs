using AutoMapper;
using HR.LeaveManagement.Application.Features.LeaveRequests.Request.Commands;
using HR.LeaveManagement.Application.Persistence.Contracts;
using HR.LeaveManagement.Domain;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveRequests.Handlers.Commands;

public class CreateLeaveRequestCommandHandler(
    ILeaveRequestRepository _leaveRequestRepository,
    IMapper _mapper
) : IRequestHandler<CreateLeaveRequestCommand, int>
{
    public async Task<int> Handle(
        CreateLeaveRequestCommand request,
        CancellationToken cancellationToken
    )
    {
        var leaveRequest = _mapper.Map<LeaveRequest>(request);
        leaveRequest = await _leaveRequestRepository.AddAsync(leaveRequest);
        return leaveRequest.Id;
    }
}
