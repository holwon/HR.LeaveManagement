using System.Reflection;
using HR.LeaveManagement.Application.Profiles;
using Microsoft.Extensions.DependencyInjection;

namespace HR.LeaveManagement.Application;

public static class ApplicationServicesRegistration
{
    public static void Registration(this IServiceCollection services)
    {
        // 这样子会遍历所有继承了 Profile 的类进行注入
        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        // services.AddAutoMapper(typeof(MappingProfile));
    }
}
