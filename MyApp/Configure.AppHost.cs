using Funq;
using MyApp.Data;
using MyApp.ServiceInterface;
using ServiceStack;
using ServiceStack.Auth;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using MyApp.ServiceModel;

[assembly: HostingStartup(typeof(MyApp.AppHost))]

namespace MyApp;

public class AppHost : AppHostBase, IHostingStartup
{
    public void Configure(IWebHostBuilder builder) => builder
        .ConfigureServices((context, services) =>
        {
            // Configure ASP.NET Core IOC Dependencies
        });

    public AppHost() : base("MyApp", typeof(MyServices).Assembly) { }

    // Configure your AppHost with the necessary configuration and dependencies your App needs
    public override void Configure(Container container)
    {
        SetConfig(new HostConfig
        {
            AdminAuthSecret = "secretz",
        });
    }
}

// Add any additional metadata properties you want to store in the Users Typed Session
public class CustomUserSession : AuthUserSession
{
}