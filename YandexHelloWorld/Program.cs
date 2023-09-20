namespace YandexHelloWorld;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllers();
        builder.WebHost.UseUrls(
            "http://localhost:5058", // must match Properties/launchSettings.json/profiles/http/applicationUrl
            "http://127.0.0.1:" + Environment.GetEnvironmentVariable("PORT")); // used for Yandex Serverless

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        app.UseAuthorization();
        app.MapControllers();
        app.Run();
    }
}

