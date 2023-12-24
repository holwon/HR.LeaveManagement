using HR.LeaveManagement.Application.Dtos.LeaveRequest;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveRequests.Request.Queries;

public class GetLeaveRequestListRequest : IRequest<List<LeaveRequestDto>> { }
