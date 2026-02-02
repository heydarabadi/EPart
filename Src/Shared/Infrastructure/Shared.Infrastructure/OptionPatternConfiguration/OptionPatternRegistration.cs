using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Shared.Infrastructure.OptionPatternConfiguration;

public static class OptionPatternRegistration
{
    public static IServiceCollection AddOptionsFromConfig<T>(
        this IServiceCollection services,
        IConfiguration configuration,
        string? sectionName = null,
        Action<T>? configure = null)
        where T : class
    {
        string effectiveSection = sectionName
                                  ?? GetSectionNameFromConstant<T>()
                                  ?? typeof(T).Name;  

        services
            .AddOptions<T>()                          
            .Bind(configuration.GetSection(effectiveSection));  

        if (configure != null)
        {
            services.PostConfigure<T>(configure);
        }

   

        return services;
    }

    private static string? GetSectionNameFromConstant<T>()
    {
        var field = typeof(T).GetField("SectionName",
            System.Reflection.BindingFlags.Public |
            System.Reflection.BindingFlags.Static |
            System.Reflection.BindingFlags.FlattenHierarchy);

        return field?.GetValue(null) as string;
    }
}