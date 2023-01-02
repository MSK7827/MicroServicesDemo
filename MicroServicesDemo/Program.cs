using InstitutionApi.Context;
using InstitutionApi.Repository.Implementations;
using InstitutionApi.Repository.InterFaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
ConfigurationManager configuration = builder.Configuration; // allows both to access and to set up the config
IWebHostEnvironment environment = builder.Environment;
builder.Services.AddDbContext<InstitutionDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("conn")));
builder.Services.AddTransient<IInstitutionRepository, InstitutionRepo>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
//IConfiguration configuration = app.Configuration;
//IWebHostEnvironment environment = app.Environment;

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.Use(async (context, next) =>
{
    var routeData = context.GetRouteData();
    var tenant = routeData?.Values["sandeep"]?.ToString();
    if (!string.IsNullOrEmpty(tenant))
        context.Items["sandeep"] = tenant;

    await next();
});

app.MapControllers();

app.Run();
