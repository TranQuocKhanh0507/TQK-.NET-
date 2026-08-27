var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.TqkLession01MVC_ApiService>("apiservice")
    .WithHttpHealthCheck("/health");

builder.AddProject<Projects.TqkLession01MVC_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithHttpHealthCheck("/health")
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
