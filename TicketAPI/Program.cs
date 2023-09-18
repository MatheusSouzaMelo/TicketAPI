using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Options;
using TicketAPI;
using TicketAPI.Controllers.Ticket;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddApiVersioning(cfg => 
{
    cfg.ReportApiVersions = true;
    cfg.Conventions.Controller<TicketController>().HasApiVersion(new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0));
    cfg.AssumeDefaultVersionWhenUnspecified = true;
    cfg.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);
});
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<Program>());

SwaggerConfiguration.ConfigureSwagger(builder.Services);
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
