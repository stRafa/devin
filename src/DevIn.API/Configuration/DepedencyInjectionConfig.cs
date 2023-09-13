using DevIn.API.Extensions;
using DevIn.Business.Interfaces;
using DevIn.Business.Notifications;

namespace DevIn.API.Configuration
{
    public static class DepedencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<INotificator, Notificator>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IUser, AspNetUser>();

            return services;
        }
    }
}
