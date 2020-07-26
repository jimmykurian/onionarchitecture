using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using MediatR;


namespace Application
{
    public static class DependencyInjection
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
        }
    }
}
