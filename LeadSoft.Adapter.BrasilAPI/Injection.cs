using Microsoft.Extensions.DependencyInjection;

namespace LeadSoft.Adapter.BrasilAPI
{
    /// <summary>
    /// Adds the BrasilApi service to the specified <see cref="IServiceCollection"/> with the specified lifetime.
    /// </summary>
    /// <remarks>This method registers the <see cref="IBrasilApi"/> implementation in the dependency    
    /// injection container. Use a singleton lifetime for shared state across the application, or a scoped lifetime    
    /// for a new instance per request.</remarks>
    public static class Injection
    {
        /// <summary>
        /// Adds the BrasilApi service to the specified <see cref="IServiceCollection"/> with the specified lifetime.
        /// </summary>
        /// <remarks>This method registers the <see cref="IBrasilApi"/> implementation in the dependency
        /// injection container. Use a singleton lifetime for shared state across the application, or a scoped lifetime
        /// for a new instance per request.</remarks>
        /// <param name="services">The <see cref="IServiceCollection"/> to which the BrasilApi service will be added.</param>
        /// <param name="useSingleton">A boolean value indicating whether to register the BrasilApi service as a singleton. <see langword="true"/>
        /// to register as a singleton; otherwise, <see langword="false"/> to register with a scoped lifetime.</param>
        public static void AddBrasilApi(this IServiceCollection services, bool useSingleton = false)
        {
            if (useSingleton)
                services.AddSingleton<IBrasilApi, BrasilApi>();
            else
                services.AddScoped<IBrasilApi, BrasilApi>();
        }
    }
}
