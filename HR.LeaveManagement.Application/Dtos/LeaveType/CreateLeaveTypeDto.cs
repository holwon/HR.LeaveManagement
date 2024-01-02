using FluentValidation;

namespace HR.LeaveManagement.Application.Dtos.LeaveType;

/// 虽然这里的属性貌似和 <see cref="LeaveTypeDto"/> 一样,
/// 可是create是不需要Id的, 所以我们还是多创建了一个除了, 作为区分
public record CreateLeaveTypeDto
{
    public required string Name { get; set; }
    public int DefaultDays { get; set; }
}

public class CreateLeaveTypeDtoValidator : AbstractValidator<CreateLeaveTypeDto>
{
    public CreateLeaveTypeDtoValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("[Name] must be specified");
    }
}
