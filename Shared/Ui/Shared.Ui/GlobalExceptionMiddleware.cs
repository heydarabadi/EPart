using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Shared.Domain;

namespace Shared.Ui;

public class GlobalExceptionHandler : IExceptionHandler
{
    private readonly ILogger<GlobalExceptionHandler> _logger;

    public GlobalExceptionHandler(ILogger<GlobalExceptionHandler> logger)
    {
        _logger = logger;
    }

    public async ValueTask<bool> TryHandleAsync(
        HttpContext httpContext,
        Exception exception,
        CancellationToken cancellationToken)
    {
        _logger.LogError(exception, "خطای مدیریت نشده: {Message}", exception.Message);

        // تعیین وضعیت پاسخ بر اساس نوع اکسپشن
        var (statusCode, errorCode) = exception switch
        {
            DomainException dex => (StatusCodes.Status400BadRequest, dex.Code),
            UnauthorizedAccessException => (StatusCodes.Status401Unauthorized, "Unauthorized"),
            _ => (StatusCodes.Status500InternalServerError, "InternalServerError")
        };

        httpContext.Response.StatusCode = statusCode;
        httpContext.Response.ContentType = "application/json";

        // ساخت بدنه پاسخ (مشابه پترن Result)
        var response = new
        {
            IsSuccess = false,
            Message = statusCode == StatusCodes.Status500InternalServerError 
                ? "خطایی در سمت سرور رخ داده است." 
                : exception.Message,
            Code = errorCode
        };

        await httpContext.Response.WriteAsJsonAsync(response, cancellationToken);

        return true; // تایید هندل شدن خطا
    }
}