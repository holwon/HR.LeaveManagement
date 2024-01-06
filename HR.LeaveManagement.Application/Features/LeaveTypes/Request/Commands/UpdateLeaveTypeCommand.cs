using FluentValidation;
using HR.LeaveManagement.Application.Dtos.LeaveType;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveTypes.Request.Commands;

public record UpdateLeaveTypeCommand : IRequest<Unit>
{
    public required LeaveTypeDto LeaveTypeDto { get; set; }
}

public class UpdateLeaveTypeCommandValidator : AbstractValidator<UpdateLeaveTypeCommand>
{
    public UpdateLeaveTypeCommandValidator()
    {
        RuleFor(x => x.LeaveTypeDto)
            .NotEmpty()
            .WithMessage("can not be empty")
            .WithErrorCode("400");
    }
}
