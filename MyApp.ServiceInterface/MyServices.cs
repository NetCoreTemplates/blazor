using MyApp.ServiceModel;
using ServiceStack;
using ServiceStack.Configuration;

namespace MyApp.ServiceInterface;

public class MyServices : Service
{
    public object Any(Hello request)
    {
        return new HelloResponse { Result = $"Hello, {request.Name}!" };
    }

    [Authenticate]
    public object Any(RequiresAuth request)
    {
        return new RequiresAuthResponse { Result = $"Hello, {request.Name}!" };
    }

    [RequiredRole("Manager")]
    public object Any(RequiresRole request)
    {
        return new RequiresRoleResponse { Result = $"Hello, {request.Name}!" };
    }

    [RequiredRole(nameof(RoleNames.Admin))]
    public object Any(RequiresAdmin request)
    {
        return new RequiresAdminResponse { Result = $"Hello, {request.Name}!" };
    }
}