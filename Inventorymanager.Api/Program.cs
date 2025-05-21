using System.Reflection;
using InventoryManager.Api.Repositories;
using InventoryManager.Api.Repositories.Interfaces;
using InventoryManager.Infrastructure;
using Microsoft.EntityFrameworkCore;

ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
{
    builder.AddFilter("Microsoft", LogLevel.Information)
        .AddFilter("System", LogLevel.Information)
        .AddFilter("SampleApp.Program", LogLevel.Information)
        .AddConsole();
});
var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
//repo
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddMvc(options => options.EnableEndpointRouting = false);
// Register MediatR
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

string connection = "Server=DESKTOP-DHD9UCL\\SQLEXPRESS;Database=InventoryDb;Trusted_Connection=True;TrustServerCertificate=True;";
builder.Services.AddDbContext<InventoryManagerDbContext>(options =>
    {
        options.UseSqlServer(connection,
            sqlOptions =>
            {
                sqlOptions.UseCompatibilityLevel(110);
                sqlOptions.CommandTimeout(30);
                sqlOptions.EnableRetryOnFailure(3, TimeSpan.FromSeconds(5), errorNumbersToAdd: null);
            });
#if DEBUG
        options.EnableSensitiveDataLogging().UseLoggerFactory(loggerFactory);
#endif
    }
);
// Configure CORS Policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    {
        builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
// Enable CORS
app.UseCors("AllowAll");
app.UseHttpsRedirection();
app.UseMvc();
app.Run();
