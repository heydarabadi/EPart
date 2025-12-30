namespace Shared.Ui;

public class ApiErrorResponse
{
    public bool IsSuccess => false;
    public string Message { get; set; }
    public string? Code { get; set; }
    public string? Details { get; set; }
}