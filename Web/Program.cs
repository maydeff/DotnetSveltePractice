using Service.Extensions;
using Shared;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddOptions<NoSqlSettings>().Bind(builder.Configuration.GetSection(NoSqlSettings.ConfigurationKey));
builder.Services.AddOptions<PostgreSettings>().Bind(builder.Configuration.GetSection(PostgreSettings.ConfigurationKey));

builder.Services.AddMongoService(builder.Configuration[$"{NoSqlSettings.ConfigurationKey}:ConnectionString"] ?? string.Empty);
builder.Services.AddPostgreService(builder.Configuration[$"{PostgreSettings.ConfigurationKey}:ConnectionString"] ?? string.Empty);


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.UseCors(app => app.WithOrigins("http://localhost:5173").AllowAnyHeader().AllowAnyMethod());

app.Run();
