using System.ComponentModel.DataAnnotations.Schema;
using HR.LeaveManagement.Domain.Common;

namespace HR.LeaveManagement.Domain;

public class LeaveRequest : BaseDomainEntity
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    [NotMapped]
    public LeaveType? LeaveType { get; set; }
    public int LeaveTypeId { get; set; }

    // DateRequested 这个可以靠系统输入
    // public DateTime DateRequested { get; set; }
    public string? RequestComments { get; set; }
    public DateTime DateActioned { get; set; }
    public bool Approved { get; set; } = true;
    public bool Cancelled { get; set; }
}
