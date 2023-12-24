using HR.LeaveManagement.Application.Dtos;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveTypes.Request.Queries;

public class GetLeaveTypeDetailRequest : IRequest<LeaveTypeDto>
{
    public int Id { get; set; }
}
