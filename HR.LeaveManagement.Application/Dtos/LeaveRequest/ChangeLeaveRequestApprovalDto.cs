using HR.LeaveManagement.Application.Dtos.Common;

namespace HR.LeaveManagement.Application.Dtos.LeaveRequest;

public record ChangeLeaveRequestApprovalDto : BaseDto
{
    public bool Approved { get; set; }
}
