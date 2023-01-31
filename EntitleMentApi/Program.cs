using EntitleMentApi.Context;
using EntitleMentApi.Repo.Implementations;
using EntitleMentApi.Repo.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
ConfigurationManager configuration = builder.Configuration; // allows both to access and to set up the config
IWebHostEnvironment environment = builder.Environment;
builder.Services.AddDbContext<EntitleMentContext>(options => options.UseSqlServer(configuration.GetConnectionString("conn")));
builder.Services.AddHttpClient("client", x =>
{
    x.DefaultRequestHeaders.Add("Accept", "application/json");
    x.DefaultRequestHeaders.Add("Xrequest", "");
});
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddTransient<ITree, Tree>();
builder.Services.AddTransient<IValue, Value>();
builder.Services.AddTransient<IDefinition, Definition>();
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
