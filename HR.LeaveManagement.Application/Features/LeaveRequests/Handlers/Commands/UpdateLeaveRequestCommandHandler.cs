using AutoMapper;
using HR.LeaveManagement.Application.Features.LeaveRequests.Request.Commands;
using HR.LeaveManagement.Application.Persistence.Contracts;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveRequests.Handlers.Commands;

public class UpdateLeaveRequestCommandHandler(
    ILeaveRequestRepository _leaveRequestRepository,
    IMapper _mapper
) : IRequestHandler<UpdateLeaveRequestCommand, Unit>
{
    public async Task<Unit> Handle(
        UpdateLeaveRequestCommand request,
        CancellationToken cancellationToken
    )
    {
        var LeaveRequest = await _leaveRequestRepository.GetAsync(request.Id);
        if (request.LeaveRequestDto is not null)
        {
            _mapper.Map(request.LeaveRequestDto, LeaveRequest);
            await _leaveRequestRepository.UpdateAsync(LeaveRequest);
        }
        else if (request.ChangeLeaveRequestApprovalDto is not null)
        {
            await _leaveRequestRepository.ChangeApprovalStatus(
                LeaveRequest,
                request.ChangeLeaveRequestApprovalDto.Approved
            );
        }

        return Unit.Value;
    }
}
