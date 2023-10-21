using ServiceStack;

namespace MyApp.ServiceModel;

[Route("/hello")]
[Route("/hello/{Name}")]
public class Hello : IReturn<HelloResponse>
{
    public string? Name { get; set; }
}

public class HelloResponse
{
    public string Result { get; set; }
}

[Route("/requiresauth")]
[Route("/requiresauth/{Name}")]
public class RequiresAuth : IReturn<RequiresAuthResponse>
{
    public string? Name { get; set; }
}

public class RequiresAuthResponse
{
    public string? Result { get; set; }
}

[Route("/requiresrole")]
[Route("/requiresrole/{Name}")]
public class RequiresRole : IReturn<RequiresRoleResponse>
{
    public string? Name { get; set; }
}

public class RequiresRoleResponse
{
    public string Result { get; set; }
}

[Route("/requiresadmin")]
[Route("/requiresadmin/{Name}")]
public class RequiresAdmin : IReturn<RequiresAdminResponse>
{
    public string? Name { get; set; }
}

public class RequiresAdminResponse
{
    public string? Result { get; set; }
}
