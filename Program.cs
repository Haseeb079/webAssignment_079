using testdb.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
var connectionString builder.Configuration.GetConnectionString("dbconnection");
builder.Services.Adddbcontext<Appdbcontext>(Options => Options.usesqlserver(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
