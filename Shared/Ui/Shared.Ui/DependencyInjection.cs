using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Shared.Ui;

public static class DependencyInjection
{
    public static IServiceCollection AddSharedExceptionHandler(this IServiceCollection services)
    {
        services.AddExceptionHandler<GlobalExceptionHandler>();
        services.AddProblemDetails(); // برای سازگاری با استانداردهای مدرن
        return services;
    }
    
    public static IApplicationBuilder UseSharedExceptionHandler(this IApplicationBuilder app)
    {
        // فعال‌سازی سیستم مدیریت خطای سراسری
        app.UseExceptionHandler();

        // می‌توانید تنظیمات دیگر مثل Swagger یا Routing مشترک را هم اینجا اضافه کنید
        
        return app;
    }
}