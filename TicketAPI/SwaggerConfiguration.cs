using Microsoft.OpenApi.Models;

namespace TicketAPI
{
    public static class SwaggerConfiguration
    {
        public static IServiceCollection ConfigureSwagger(IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "1",
                    Title = "Ticket API",
                    Description = "An ASP.NET Core Web API for managing tickets",
                });
            });

            return services;
        }
    }
}
