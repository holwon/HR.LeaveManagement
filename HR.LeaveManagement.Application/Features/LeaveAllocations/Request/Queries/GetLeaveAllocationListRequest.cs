using HR.LeaveManagement.Application.Dtos.LeaveAllocation;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveAllocations.Request.Queries;

public class GetLeaveAllocationListRequest : IRequest<List<LeaveAllocationDto>> { }
