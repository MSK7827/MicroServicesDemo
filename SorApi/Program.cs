using Microsoft.EntityFrameworkCore;
using SorApi.Context;
using SorApi.Repo.Implementations;
using SorApi.Repo.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
ConfigurationManager configuration = builder.Configuration; // allows both to access and to set up the config
IWebHostEnvironment environment = builder.Environment;
builder.Services.AddDbContext<SorDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("conn")));
builder.Services.AddHttpClient("client", x =>
{
   x.DefaultRequestHeaders.Add("Accept", "application/json");
    x.DefaultRequestHeaders.Add("Xrequest", "");
});
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddTransient<ISorRepo, SorRepo>();
//builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddControllers();
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
