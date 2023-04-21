using Microsoft.EntityFrameworkCore;
using x91128x.Utility;
using xData.Data;

var CORS_POLICY = "CORS_POLICY";

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEntityFramework(builder.Configuration.GetConnectionString("DefaultConnection"));
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: CORS_POLICY, policy =>
    {
        policy.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod();
    });
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(CORS_POLICY);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
