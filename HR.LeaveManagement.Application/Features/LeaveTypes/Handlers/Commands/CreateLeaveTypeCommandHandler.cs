using AutoMapper;
using HR.LeaveManagement.Application.Features.LeaveTypes.Request.Commands;
using HR.LeaveManagement.Application.Persistence.Contracts;
using HR.LeaveManagement.Domain;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveTypes.Handlers.Commands;

public class CreateLeaveTypeRequestHandler(
    ILeaveTypeRepository _leaveTypeRepository,
    IMapper _mapper
) : IRequestHandler<CreateLeaveTypeCommand, int>
{
    public async Task<int> Handle(
        CreateLeaveTypeCommand request,
        CancellationToken cancellationToken
    )
    {
        var leaveType = _mapper.Map<LeaveType>(request.LeaveTypeDto);

        leaveType = await _leaveTypeRepository.AddAsync(leaveType);
        return leaveType.Id;
    }
}
