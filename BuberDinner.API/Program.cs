using BuberDinner.Application;
using BuberDinner.Infraestructure;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddInfraestructure();
    builder.Services.AddApplication();
    builder.Services.AddControllers();
}

var app = builder.Build();
{
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}