namespace project;
public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        app.MapGet("/", () => "Hello from C#!");
        app.MapGet("/health", () => Results.Ok(new { status = "Healthy" }));

        app.Run("http://0.0.0.0:8080");
    }
}