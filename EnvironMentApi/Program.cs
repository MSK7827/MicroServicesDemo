using EnvironMentApi.context;
using EnvironMentApi.Filters;
using EnvironMentApi.Repo.Implimentations;
using EnvironMentApi.Repo.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
ConfigurationManager configuration = builder.Configuration; // allows both to access and to set up the config
IWebHostEnvironment environment = builder.Environment;
builder.Services.AddDbContext<EnvironMentDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("conn")));
builder.Services.AddTransient<IEnvironment, EnvironmtRepo>();
//builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddControllers( options=>
{
    options.Filters.Add<ServiceContext>();
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
