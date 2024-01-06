using FluentValidation;
using HR.LeaveManagement.Application.Dtos.LeaveAllocation;
using HR.LeaveManagement.Application.Dtos.LeaveRequest;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveAllocations.Request.Commands;

public record UpdateLeaveAllocationCommand : IRequest<Unit>
{
    public required UpdateLeaveAllocationDto LeaveAllocationDto { get; set; }
}

public class UpdateLeaveAllocationCommandValidator : AbstractValidator<UpdateLeaveAllocationCommand>
{
    public UpdateLeaveAllocationCommandValidator()
    {
        RuleFor(x => x.LeaveAllocationDto).NotEmpty();
    }
}
