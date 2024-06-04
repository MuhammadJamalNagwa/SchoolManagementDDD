using Microsoft.EntityFrameworkCore;
using SchoolManagement.PersistenceDB.Database;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
    string? connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
                                        ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

    builder.Services.AddDbContextPool<ApplicationDbContext>(options =>
    {
        options.UseSqlServer(connectionString);
        options.UseLazyLoadingProxies();
    });
}



WebApplication app = builder.Build();
{
    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    app.Run();
}


