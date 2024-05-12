using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

namespace BlazorAppSolution.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            return services;
        }
    }
}
