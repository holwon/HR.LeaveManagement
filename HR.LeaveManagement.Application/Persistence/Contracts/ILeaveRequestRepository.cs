using HR.LeaveManagement.Domain;

namespace HR.LeaveManagement.Application.Persistence.Contracts;

public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
{
    Task<LeaveRequest> GetLeaveRequestWithDetailAsync(int id);
    Task<List<LeaveRequest>> GetLeaveRequestsWithDetailAsync();
    Task ChangeApprovalStatus(LeaveRequest leaveRequest, bool isApprovalStatus);
}
