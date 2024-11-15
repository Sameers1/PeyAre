var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.PeyAre>("peyare");

builder.Build().Run();
