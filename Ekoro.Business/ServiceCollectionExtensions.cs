//using Ekoro.Business.Services;
//using Ekoro.Core.Interfaces.Business;

namespace Microsoft.Extensions.DependencyInjection;

/// <summary>
/// Provides extensions methods for <see cref="IServiceCollection"/>.
/// </summary>
public static class ServiceCollectionExtensions
{
    public static void AddBusinessServices(this IServiceCollection services)
    {
        //services.AddScoped<IContentService, ContentService>();
    }
}
