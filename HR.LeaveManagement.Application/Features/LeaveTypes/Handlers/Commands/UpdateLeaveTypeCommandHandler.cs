using AutoMapper;
using HR.LeaveManagement.Application.Features.LeaveTypes.Request.Commands;
using HR.LeaveManagement.Application.Persistence.Contracts;
using HR.LeaveManagement.Domain;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveTypes.Handlers.Commands;

public class UpdateLeaveTypeCommandHandler(
    ILeaveTypeRepository _leaveTypeRepository,
    IMapper _mapper
) : IRequestHandler<UpdateLeaveTypeCommand, Unit>
{
    public async Task<Unit> Handle(
        UpdateLeaveTypeCommand request,
        CancellationToken cancellationToken
    )
    {
        var leaveType = await _leaveTypeRepository.GetAsync(request.LeaveTypeDto.Id);
        _mapper.Map(request.LeaveTypeDto, leaveType);
        await _leaveTypeRepository.UpdateAsync(leaveType);
        return Unit.Value;
    }
}
